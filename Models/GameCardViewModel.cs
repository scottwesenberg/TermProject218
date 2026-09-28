#nullable disable
namespace AllGamesGameReviews.Models
{
    // One game tile on the Games page: the game plus its review stats
    public class GameCardViewModel
    {
        public Game Game { get; set; }
        public double? AverageRating { get; set; }
        public int ReviewCount { get; set; }
    }
}
