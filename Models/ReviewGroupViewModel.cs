#nullable disable
namespace AllGamesGameReviews.Models
{
    // One row on the Reviews page: a game, its stats and a few of its reviews
    public class ReviewGroupViewModel
    {
        public Game Game { get; set; }
        public double? AverageRating { get; set; }
        public int ReviewCount { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
