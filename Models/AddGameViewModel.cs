#nullable disable
namespace TermProject1.Models
{
    public class AddGameViewModel
    {
        public Game Game { get; set; }

        public List<string> CategoryIds { get; set; }

        public List<Category> Categories { get; set; }
    }
}
