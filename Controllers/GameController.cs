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
using TermProject1.Models;



namespace TermProject1.Controllers
{
    public class GameController : Controller
    {
        private readonly GameContext _context;

        public GameController(GameContext context)
        {
            _context = context;
        }

        // GET: Game

        public IActionResult Index(string sortOrder)
        {
            ViewData["NameSortParam"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CreatorSortParam"] = sortOrder == "creator" ? "creator_desc" : "creator";
            ViewData["DateSortParam"] = sortOrder == "date" ? "date_desc" : "date";

            var games = from g in _context.Games
                        select g;

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
                default:
                    games = games.OrderBy(s => s.Name);
                    break;
            }
            return View(games);
        }
        [HttpPost]
        public IActionResult IndexWithSearch(string search)
        {
            // Query all games or filter based on the search query
            var games = string.IsNullOrEmpty(search)
                ? _context.Games.ToList()
                : _context.Games.Where(g => g.Name.Contains(search)).ToList();

            ViewBag.SearchQuery = search; // Pass the search query to the view

            return View("Index",games);
        }


        // GET: Game/Details/5
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

            return View(game);
        }




        // GET: Game/Create
        public IActionResult Create()
        {
            var addGameViewModel = new AddGameViewModel();

            addGameViewModel.Categories = _context.Categories.ToList();

            return View(addGameViewModel);
        }

        // POST: Game/Create


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddGameViewModel addGameViewModel)
        {
            

            
            var categories = _context.Categories.ToList();

            if (ModelState.IsValid)
            {
                // Add the game to the context
                _context.Add(addGameViewModel.Game);
                _context.SaveChanges();

                //add GameCategories
                foreach (var category in addGameViewModel.CategoryIds)
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

            return View(addGameViewModel);
        }

        // GET: Game/Edit/5
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
            return View(game);
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GameId,Name,Creator,Year,IGNRating")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
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
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        // GET: Game/Delete/5
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Games == null)
            {
                return Problem("Entity set 'GameContext.Games'  is null.");
            }
            var game = await _context.Games.FindAsync(id);
            if (game != null)
            {
                _context.Games.Remove(game);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
          return (_context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
