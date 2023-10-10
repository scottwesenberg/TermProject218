#nullable disable
using System.ComponentModel.DataAnnotations.Schema;

namespace TermProject1.Models
{
    public class GameCategory
    {
   
        public int GameCategoryId { get; set; }

        [ForeignKey("Game")]
        public int GameId { get; set; }
        public virtual Game Game { get; set; }

        [ForeignKey("Category")]
        public string CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
