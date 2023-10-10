#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject1.Models
{
    public class Category
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
