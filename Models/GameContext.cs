#nullable disable
using Humanizer.Localisation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TermProject1.Models;

// https://www.youtube.com/watch?v=ZXynHdk35fU&t=2s ADDING CATEGORY 

namespace TermProject1.Models
{
    public class GameContext : DbContext
    {
        //public UserManager UserManager { get; set; }
        public GameContext(DbContextOptions<GameContext> options) : base(options){ }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = "A", Name = "Action" },
                new Category { Id = "C", Name = "Comedy" },
                new Category { Id = "D", Name = "Adventure" },
                new Category { Id = "O", Name = "Open-World" },
                new Category { Id = "F", Name = "Sci-Fi" },
                new Category { Id = "RPG", Name = "Role-Playing" },
                new Category { Id = "S", Name = "Shooter" },
                new Category { Id ="FAN", Name = "Fantasy"},
                new Category { Id = "CAS", Name = "Casual" },
                new Category { Id = "COMP", Name = "Competitive" },
                new Category { Id = "STR", Name = "Strategy" },
                new Category { Id = "SPORT", Name = "Sports" }

            );

            modelBuilder.Entity<Game>().HasData(
                    new Game
                    {
                        Id = 1,
                        Name = "Red Dead Redemption 2",
                        Creator = "Rockstar Studios",
                        Year = 2018,
                        IGNRating = 10,
                        Description = "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game's vast and atmospheric world also provides the foundation for a brand new online multiplayer experience."
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Starfield",
                        Creator = "Bethesda Game Studios",
                        Year = 2023,
                        IGNRating = 7,
                        Description = "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin."
                    },
                    new Game
                    {
                        Id = 3,
                        Name = "Elden Ring",
                        Creator = "FromSoftware",
                        Year = 2022,
                        IGNRating = 10,
                        Description = "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout."
                    }

            );
            modelBuilder.Entity<GameCategory>().HasData(
                new { GameCategoryId = 1, GameId = 1, CategoryId = "O" },
                new { GameCategoryId = 2, GameId = 1, CategoryId = "S" },
                new { GameCategoryId = 3, GameId = 1, CategoryId = "A" }, 
                new { GameCategoryId = 4, GameId = 2, CategoryId = "F" },
                new { GameCategoryId = 5, GameId = 2, CategoryId = "O" },
                new { GameCategoryId = 6, GameId = 3, CategoryId = "RPG" }, 
                new { GameCategoryId = 7, GameId = 3, CategoryId = "F" },
                new { GameCategoryId = 8, GameId = 3, CategoryId = "FAN" }

            );
            modelBuilder.Entity<Review>().HasData(
                new { ReviewId = 1, GameId = 1,GameRating= 9.3f, GameReview="This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly reccomend this game to anyone who likes a semi-casual shooter with amazing graphics and a gret story."},
                new { ReviewId = 2, GameId = 2, GameRating = 7.5f, GameReview = "Starfield is a cool space experiece with quite a bit to offer. It has game physics that will keep you insterested, but I have a hard time wanting to follow to story. I'd rather just explore the vastness of space." },
                new { ReviewId = 3, GameId = 2, GameRating = 9.3f, GameReview = "BEST GAME EVER I LOVE SPACE" },
                new { ReviewId = 4, GameId = 3, GameRating = 9f, GameReview = "Elden Ring is a gorgeous open world game, with seamless graphics and fighting mechanics. It is a beautifully made game, though it is very difficult!" }
            );
        }
        public DbSet<TermProject1.Models.Review>? Review { get; set; }
    }
}
