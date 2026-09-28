#nullable enable
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AllGamesGameReviews.Models
{
    // Works out the name shown on each review
    public static class ReviewerNames
    {
        // Gamer tags for the seeded demo reviews (they weren't written by real accounts)
        private static readonly string[] SeedHandles =
        {
            "PixelPaladin", "NoScopeNana", "CritHitCarl", "SaveScummer", "LootGoblin", "RespawnRita",
            "BossRushBen", "SpeedrunSam", "ComboQueen", "FogOfWarFrank", "ManaPotionMo", "SideQuestSue",
            "GlitchHunter", "TankMainTess", "HealBotHank", "ArcadeAvery", "CouchCoopCal", "NPCNate"
        };

        // Fills AuthorName on each review: the account's username, or a demo tag for seeded reviews
        public static async Task FillAsync(IEnumerable<Review> reviews, UserManager<IdentityUser> userManager)
        {
            var list = reviews.ToList();
            var ids = list.Where(r => r.UserId != null).Select(r => r.UserId!).Distinct().ToList();
            var names = ids.Count == 0
                ? new Dictionary<string, string?>()
                : await userManager.Users.Where(u => ids.Contains(u.Id))
                    .ToDictionaryAsync(u => u.Id, u => u.UserName);

            foreach (var review in list)
            {
                if (review.UserId == null)
                {
                    review.AuthorName = SeedHandles[review.ReviewId % SeedHandles.Length];
                }
                else if (names.TryGetValue(review.UserId, out var userName) && !string.IsNullOrEmpty(userName))
                {
                    // Older accounts used their email as the username; never show an email publicly
                    review.AuthorName = userName.Contains('@') ? "AGGRO Member" : userName;
                }
                else
                {
                    review.AuthorName = "Former member";
                }
            }
        }
    }
}
