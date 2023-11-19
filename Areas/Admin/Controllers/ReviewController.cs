using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TermProject1.Models;

namespace TermProject1.Controllers
{
    public class ReviewController : Controller
    {
        private readonly GameContext _context;

        public ReviewController(GameContext context)
        {
            _context = context;
        }

        // GET: Review
        public IActionResult Index(int? gameId)
        {
            ViewBag.Game = gameId;
            if (gameId == null)
            {
                ViewBag.Game = "All Reviews"; // Default message when no specific game is selected
                var gameContext = _context.Review.Include(r => r.Game);
                return View(gameContext.ToList());
            }
            else
            {
                // Query the game name based on gameId
                var game = _context.Games.FirstOrDefault(g => g.Id == gameId);
                ViewBag.Game = game != null ? game.Name : "Game Not Found"; // Set the game name or a default message
            }
            // Query reviews based on gameId
            var reviews = _context.Review.Where(r => r.GameId == gameId)
                .Include(r => r.Game).ToList();

            return View(reviews);
        }

        // GET: Review/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Review == null)
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

            return View(review);
        }

        // GET: Review/Create
        public IActionResult Create(int? gameId)
        {
            if (!gameId.HasValue)
            {
                return NotFound(); // Handle the case where GameId is not provided.
            }

            var game = _context.Games.FirstOrDefault(g => g.Id == gameId);

            if (game == null)
            {
                return NotFound(); // Handle the case where the game is not found
            }

            ViewData["GameName"] = game.Name; // Set the game name in ViewData
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Name");
            var model = new Review { GameId = gameId.Value };
            return View(model);
        }

        // POST: Review/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReviewId,GameId,GameRating,GameReview")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Creator", review.GameId);
            return View(review);
        }

        // GET: Review/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            ViewBag.GameName = review.GameId;
            return View(review);
        }

        // POST: Review/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReviewId,GameId,GameRating,GameReview")] Review review)
        {
            if (id != review.ReviewId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(review);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReviewExists(review.ReviewId))
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
            ViewData["GameId"] = new SelectList(_context.Games, "Id", "Creator", review.GameId);
            return View(review);
        }

        // GET: Review/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Review == null)
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

            return View(review);
        }

        // POST: Review/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Review == null)
            {
                return Problem("Entity set 'GameContext.Review'  is null.");
            }
            var review = await _context.Review.FindAsync(id);
            if (review != null)
            {
                _context.Review.Remove(review);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReviewExists(int id)
        {
            return (_context.Review?.Any(e => e.ReviewId == id)).GetValueOrDefault();
        }
    }
}
