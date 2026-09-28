#nullable disable
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AllGamesGameReviews.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int GameId{ get; set; }
        public  Game Game { get; set; }

        [Required(ErrorMessage = "Please enter your rating.")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        [Display(Name = "Game Rating")]
        public float GameRating { get; set; }

        [Required(ErrorMessage = "Please enter your review.")]
        [StringLength(maximumLength: 3000)]
        [Display(Name = "Game Review")]
        public string GameReview { get; set; }

        // The account that wrote this review (Identity user id). Empty for the seeded demo reviews.
        [StringLength(450)]
        public string? UserId { get; set; }

        // Filled in by the controller for display; not stored in the database
        [NotMapped]
        public string AuthorName { get; set; }
    }
}
