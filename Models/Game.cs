#nullable disable
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TermProject1.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a game name.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the game creator.")]
        public string Creator { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1962, 2050, ErrorMessage = "Year must be between 1962 and now.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Display(Name = "IGN Rating")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public float IGNRating { get; set; }

        [Required(ErrorMessage = "Please enter a game description.")]
        [StringLength(maximumLength:3000)]
        public string Description { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year.ToString();

        [Required(ErrorMessage = "Please select at least 1 Category")]
        [Display(Name = "Game Categories")]
        public List<Category> GameCategories { get; set; } = new List<Category>();

    }
}
