using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AllGamesGameReviews.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;




namespace AllGamesGameReviews.Controllers
{
    
    public class GameController : Controller
    {
        private readonly GameContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<IdentityUser> _userManager;

        // Cover images are saved as files in wwwroot/images/games; the database stores the path
        private static readonly string[] AllowedImageTypes = { ".jpg", ".jpeg", ".png", ".webp" };
        private const long MaxImageBytes = 2 * 1024 * 1024; // 2 MB

        public GameController(GameContext context, IWebHostEnvironment env, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }

        // GET: Game
        [Authorize(Roles = "Administrator,Manager,User")]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string sortOrder, string search, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CreatorSortParam"] = sortOrder == "creator" ? "creator_desc" : "creator";
            ViewData["DateSortParam"] = sortOrder == "date" ? "date_desc" : "date";
            ViewBag.SearchQuery = search;

            var games = from g in _context.Games
                        select g;

            if (!string.IsNullOrWhiteSpace(search))
            {
                games = games.Where(g => g.Name.Contains(search));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    games = games.OrderByDescending(s => s.Name);
                    break;
                case "date":
                    games = games.OrderBy(s => s.Year);
                    break;
                case "date_desc":
                    games = games.OrderByDescending(s => s.Year);
                    break;
                case "creator":
                    games = games.OrderBy(s => s.Creator);
                    break;
                case "creator_desc":
                    games = games.OrderByDescending(s => s.Creator);
                    break;
                case "rating":
                    games = games.OrderByDescending(s => _context.Review.Where(r => r.GameId == s.Id).Average(r => (double?)r.GameRating)).ThenBy(s => s.Name);
                    break;
                default:
                    games = games.OrderBy(s => s.Name);
                    break;
            }

            // Add each game's average rating and review count for the game tiles
            var cards = games.AsNoTracking().Select(g => new GameCardViewModel
            {
                Game = g,
                ReviewCount = _context.Review.Count(r => r.GameId == g.Id),
                AverageRating = _context.Review.Where(r => r.GameId == g.Id).Average(r => (double?)r.GameRating)
            });

            int pageSize = 21; // 7 rows of 3
            return View(await PaginatedList<GameCardViewModel>.CreateAsync(cards, pageNumber ?? 1, pageSize));
        }

        // Search form on the home and games pages posts here, then shows page 1 of the results
        [HttpPost]
        [Authorize(Roles = "Administrator,Manager,User")]
        [AllowAnonymous]
        public IActionResult IndexWithSearch(string search)
        {
            return RedirectToAction(nameof(Index), new { search });
        }


        // GET: Game/Details/5
        [Authorize(Roles = "Administrator,Manager,User")]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the game by its ID
            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            // Retrieve the associated categories for the game
            var categoryIds = await _context.GameCategories
                .Where(gc => gc.GameId == id)
                .Select(gc => gc.CategoryId)
                .ToListAsync();

            // Retrieve the Category objects for the associated category IDs
            var categories = await _context.Categories
                .Where(c => categoryIds.Contains(c.Id))
                .ToListAsync();

            // Add the retrieved categories to the game model
            game.GameCategories = categories;

            // Rating summary and the newest reviews for the details page
            var reviews = _context.Review.AsNoTracking().Where(r => r.GameId == game.Id);
            ViewBag.ReviewCount = await reviews.CountAsync();
            ViewBag.AverageRating = await reviews.AverageAsync(r => (double?)r.GameRating);
            var recent = await reviews.OrderByDescending(r => r.ReviewId).Take(3).ToListAsync();
            await ReviewerNames.FillAsync(recent, _userManager);
            ViewBag.RecentReviews = recent;

            var userId = _userManager.GetUserId(User);
            ViewBag.MyReviewId = userId == null ? null
                : await reviews.Where(r => r.UserId == userId).Select(r => (int?)r.ReviewId).FirstOrDefaultAsync();

            return View(game);
        }




        // GET: Game/Create
        [Authorize(Roles = "Administrator,Manager")]
        public IActionResult Create()
        {
            var addGameViewModel = new AddGameViewModel();

            addGameViewModel.Categories = _context.Categories.ToList();

            return View(addGameViewModel);
        }

        // POST: Game/Create


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager")]
        public async Task<IActionResult> Create(AddGameViewModel addGameViewModel, IFormFile? coverImage)
        {
            var categories = _context.Categories.ToList();

            // Only an uploaded file can set the cover, never a typed-in value
            addGameViewModel.Game.ImageUrl = null;
            var imageError = ValidateImage(coverImage);
            if (imageError != null)
            {
                ModelState.AddModelError("coverImage", imageError);
            }

            if (ModelState.IsValid)
            {
                if (coverImage != null && coverImage.Length > 0)
                {
                    addGameViewModel.Game.ImageUrl = await SaveImageAsync(coverImage);
                }

                // Add the game to the context
                _context.Add(addGameViewModel.Game);
                _context.SaveChanges();

                //add GameCategories
                foreach (var category in addGameViewModel.CategoryIds ?? new List<string>())
                {
                    var gameCategory = new GameCategory
                    {
                        GameId = addGameViewModel.Game.Id,
                        CategoryId = category
                    };

                    _context.GameCategories.Add(gameCategory);
                }

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            // The form needs the category list again when it's redisplayed with errors
            addGameViewModel.Categories = categories;
            return View(addGameViewModel);
        }

        // GET: Game/Edit/5
        [Authorize(Roles = "Administrator,Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }
            await LoadCategoryChoicesAsync(game.Id);
            return View(game);
        }

        // Categories for the Edit form, and which ones this game already has
        private async Task LoadCategoryChoicesAsync(int gameId, IEnumerable<string>? selected = null)
        {
            ViewBag.AllCategories = await _context.Categories.OrderBy(c => c.Name).ToListAsync();
            ViewBag.SelectedCategoryIds = selected?.ToList() ?? await _context.GameCategories
                .Where(gc => gc.GameId == gameId).Select(gc => gc.CategoryId).ToListAsync();
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Creator,Year,IGNRating,Description")] Game game, IFormFile? coverImage, List<string>? CategoryIds)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            // Keep the current cover unless a new image was uploaded
            game.ImageUrl = await _context.Games.Where(g => g.Id == id).Select(g => g.ImageUrl).FirstOrDefaultAsync();
            var imageError = ValidateImage(coverImage);
            if (imageError != null)
            {
                ModelState.AddModelError("coverImage", imageError);
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (coverImage != null && coverImage.Length > 0)
                    {
                        var oldImage = game.ImageUrl;
                        game.ImageUrl = await SaveImageAsync(coverImage);
                        DeleteUploadedImage(oldImage);
                    }

                    // Replace the game's categories with the ones ticked on the form
                    var picked = (CategoryIds ?? new List<string>()).Distinct().ToList();
                    var existing = _context.GameCategories.Where(gc => gc.GameId == game.Id);
                    _context.GameCategories.RemoveRange(existing);
                    foreach (var categoryId in picked)
                    {
                        _context.GameCategories.Add(new GameCategory { GameId = game.Id, CategoryId = categoryId });
                    }

                    _context.Update(game);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Details), new { id = game.Id });
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            await LoadCategoryChoicesAsync(game.Id, CategoryIds);
            return View(game);
        }

        // GET: Game/Delete/5
        [Authorize(Roles = "Administrator,Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Games == null)
            {
                return Problem("Entity set 'GameContext.Games'  is null.");
            }
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                // Reviews and category links are removed with the game (cascade delete)
                _context.Games.Remove(game);
                await _context.SaveChangesAsync();
                DeleteUploadedImage(game.ImageUrl);
            }
            return RedirectToAction(nameof(Index));
        }
        // Returns an error message, or null if the upload is fine (or there is no upload)
        private static string? ValidateImage(IFormFile? file)
        {
            if (file == null || file.Length == 0) return null;
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (!AllowedImageTypes.Contains(ext) || !file.ContentType.StartsWith("image/"))
                return "Cover image must be a JPG, PNG or WebP file.";
            if (file.Length > MaxImageBytes)
                return "Cover image must be 2 MB or smaller.";
            return null;
        }

        // Saves the upload with a random file name and returns its web path
        private async Task<string> SaveImageAsync(IFormFile file)
        {
            var folder = Path.Combine(_env.WebRootPath, "images", "games");
            Directory.CreateDirectory(folder);
            var fileName = $"{Guid.NewGuid():N}{Path.GetExtension(file.FileName).ToLowerInvariant()}";
            using (var stream = new FileStream(Path.Combine(folder, fileName), FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return $"/images/games/{fileName}";
        }

        // Removes an uploaded cover file (random GUID name) so deleted games don't leave files behind.
        // Seeded covers use readable names and stay, since they ship with the project.
        private void DeleteUploadedImage(string? imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl) || !imageUrl.StartsWith("/images/games/")) return;
            var fileName = Path.GetFileName(imageUrl);
            if (!Guid.TryParseExact(Path.GetFileNameWithoutExtension(fileName), "N", out _)) return;
            var path = Path.Combine(_env.WebRootPath, "images", "games", fileName);
            if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
        }

        private bool GameExists(int id)
        {
          return (_context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
