using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AllGamesGameReviews.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;


namespace AllGamesGameReviews.Controllers
{
    
    public class ReviewController : Controller
    {
        private readonly GameContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ReviewController(GameContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // The review's author, or an admin/manager, can edit and delete it
        private bool CanModify(Review review) =>
            User.IsInRole("Administrator") || User.IsInRole("Manager") ||
            (review.UserId != null && review.UserId == _userManager.GetUserId(User));

        [Authorize(Roles = "Administrator,Manager,User")]
        [AllowAnonymous]
        public async Task<IActionResult> Index(int? gameId, int? pageNumber)
        {
            ViewBag.GameId = gameId;
            const int gamesPerPage = 10;
            const int reviewsPerGame = 3;

            // Games that have reviews (or just the one requested), alphabetical
            var gamesQuery = _context.Games.AsNoTracking()
                .Where(g => _context.Review.Any(r => r.GameId == g.Id));
            if (gameId != null)
            {
                gamesQuery = _context.Games.AsNoTracking().Where(g => g.Id == gameId);
                ViewBag.Game = _context.Games.FirstOrDefault(g => g.Id == gameId)?.Name;
            }
            else
            {
                ViewBag.Game = "All Reviews";
            }

            int page = Math.Max(pageNumber ?? 1, 1);
            int totalGames = await gamesQuery.CountAsync();
            var pageGames = await gamesQuery
                .OrderBy(g => g.Name)
                .Skip((page - 1) * gamesPerPage)
                .Take(gamesPerPage)
                .Select(g => new ReviewGroupViewModel
                {
                    Game = g,
                    ReviewCount = _context.Review.Count(r => r.GameId == g.Id),
                    AverageRating = _context.Review.Where(r => r.GameId == g.Id).Average(r => (double?)r.GameRating)
                })
                .ToListAsync();

            // Load the reviews for just the games on this page
            var ids = pageGames.Select(g => g.Game.Id).ToList();
            var reviews = await _context.Review.AsNoTracking()
                .Where(r => ids.Contains(r.GameId))
                .OrderByDescending(r => r.ReviewId)
                .ToListAsync();
            foreach (var group in pageGames)
            {
                var forGame = reviews.Where(r => r.GameId == group.Game.Id);
                // One game selected: show all of its reviews. Otherwise show a few per game.
                group.Reviews = (gameId != null ? forGame : forGame.Take(reviewsPerGame)).ToList();
            }
            await ReviewerNames.FillAsync(pageGames.SelectMany(g => g.Reviews), _userManager);

            return View(new PaginatedList<ReviewGroupViewModel>(pageGames, totalGames, page, gamesPerPage));
        }

        // GET: Review/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Game)
                .FirstOrDefaultAsync(m => m.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }

            await ReviewerNames.FillAsync(new[] { review }, _userManager);
            ViewBag.CanModify = User.Identity?.IsAuthenticated == true && CanModify(review);
            return View(review);
        }

        // GET: Review/Create
        [Authorize(Roles = "Administrator,Manager,User")]
        public IActionResult Create(int? gameId)
        {
            if (!gameId.HasValue)
            {
                return NotFound();
            }

            var game = _context.Games.FirstOrDefault(g => g.Id == gameId);
            if (game == null)
            {
                return NotFound();
            }

            // One review per game per account: send them to edit the one they already wrote
            var userId = _userManager.GetUserId(User);
            var existingId = _context.Review.Where(r => r.GameId == game.Id && r.UserId == userId)
                .Select(r => (int?)r.ReviewId).FirstOrDefault();
            if (existingId != null)
            {
                TempData["Notice"] = "You've already reviewed this game, so you can update your review here.";
                return RedirectToAction(nameof(Edit), new { id = existingId });
            }

            ViewData["GameName"] = game.Name;
            return View(new Review { GameId = gameId.Value });
        }

        // POST: Review/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Create([Bind("GameId,GameRating,GameReview")] Review review)
        {
            if (!_context.Games.Any(g => g.Id == review.GameId))
            {
                return NotFound();
            }

            var currentUserId = _userManager.GetUserId(User);
            if (_context.Review.Any(r => r.GameId == review.GameId && r.UserId == currentUserId))
            {
                ModelState.AddModelError(string.Empty, "You've already reviewed this game. Edit your existing review instead.");
            }

            if (ModelState.IsValid)
            {
                // Link the review to the signed-in account (never taken from the form)
                review.UserId = currentUserId;
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { gameId = review.GameId });
            }
            ViewData["GameName"] = _context.Games.FirstOrDefault(g => g.Id == review.GameId)?.Name;
            return View(review);
        }

        // GET: Review/Edit/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review.Include(r => r.Game).FirstOrDefaultAsync(r => r.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }
            if (!CanModify(review))
            {
                return Forbid();
            }
            return View(review);
        }

        // POST: Review/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewId,GameRating,GameReview")] Review input)
        {
            if (id != input.ReviewId)
            {
                return NotFound();
            }

            var review = await _context.Review.Include(r => r.Game).FirstOrDefaultAsync(r => r.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }
            if (!CanModify(review))
            {
                return Forbid();
            }

            // Only the rating and text can change; the game and author stay the same
            ModelState.Remove(nameof(Review.Game));
            if (ModelState.IsValid)
            {
                review.GameRating = input.GameRating;
                review.GameReview = input.GameReview;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { id = review.ReviewId });
            }

            input.GameId = review.GameId;
            input.Game = review.Game;
            return View(input);
        }

        // GET: Review/Delete/5
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var review = await _context.Review
                .Include(r => r.Game)
                .FirstOrDefaultAsync(m => m.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }
            if (!CanModify(review))
            {
                return Forbid();
            }

            await ReviewerNames.FillAsync(new[] { review }, _userManager);
            return View(review);
        }

        // POST: Review/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator,Manager,User")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return RedirectToAction(nameof(Index));
            }
            if (!CanModify(review))
            {
                return Forbid();
            }

            var gameId = review.GameId;
            _context.Review.Remove(review);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), new { gameId });
        }
    }
}
