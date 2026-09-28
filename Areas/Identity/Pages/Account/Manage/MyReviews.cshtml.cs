#nullable disable

using AllGamesGameReviews.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AllGamesGameReviews.Areas.Identity.Pages.Account.Manage
{
    // Lists every review written by the signed-in account
    public class MyReviewsModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly GameContext _context;

        public MyReviewsModel(UserManager<IdentityUser> userManager, GameContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public async Task<IActionResult> OnGetAsync()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }

            Reviews = await _context.Review.AsNoTracking()
                .Include(r => r.Game)
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.ReviewId)
                .ToListAsync();
            return Page();
        }
    }
}
