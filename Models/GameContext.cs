using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermProject1.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options){ }
        public DbSet<Game> Games { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Game>().HasData(
                    new Game
                    {
                        GameId = 1,
                        Name = "Red Dead Redemption 2",
                        Creator = "Rockstar Studios",
                        Year = 2018,
                        IGNRating = 10,
                    },
                    new Game
                    {
                        GameId = 2,
                        Name = "Starfield",
                        Creator = "Bethesda Game Studios",
                        Year = 2023,
                        IGNRating = 7,
                    },
                    new Game
                    {
                        GameId = 3,
                        Name = "Elden Ring",
                        Creator = "FromSoftware",
                        Year = 2022,
                        IGNRating = 10,
                    }
            );
        }
    }
}
