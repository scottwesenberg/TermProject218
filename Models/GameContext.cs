#nullable disable
using Microsoft.EntityFrameworkCore;

// https://www.youtube.com/watch?v=ZXynHdk35fU&t=2s ADDING CATEGORY 

namespace AllGamesGameReviews.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options){ }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GameCategory> GameCategories { get; set; }
        public DbSet<AllGamesGameReviews.Models.Review>? Review { get; set; }

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
                new Category { Id = "FAN", Name = "Fantasy" },
                new Category { Id = "CAS", Name = "Casual" },
                new Category { Id = "COMP", Name = "Competitive" },
                new Category { Id = "STR", Name = "Strategy" },
                new Category { Id = "SPORT", Name = "Sports" }
            );

            // IGN ratings are the scores from IGN's original reviews
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    Name = "Red Dead Redemption 2",
                    Creator = "Rockstar Studios",
                    Year = 2018,
                    IGNRating = 10f,
                    Description = "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game's vast and atmospheric world also provides the foundation for a brand new online multiplayer experience."
                },
                new Game
                {
                    Id = 2,
                    Name = "Starfield",
                    Creator = "Bethesda Game Studios",
                    Year = 2023,
                    IGNRating = 7f,
                    Description = "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout."
                },
                new Game
                {
                    Id = 3,
                    Name = "Elden Ring",
                    Creator = "FromSoftware",
                    Year = 2022,
                    IGNRating = 10f,
                    Description = "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin."
                },
                new Game
                {
                    Id = 4,
                    Name = "The Legend of Zelda: Breath of the Wild",
                    Creator = "Nintendo EPD",
                    Year = 2017,
                    IGNRating = 10f,
                    Description = "Link wakes from a century-long sleep to find Hyrule in ruins. Climb, glide and explore a huge open world at your own pace, solving shrines and taking on Calamity Ganon whenever you feel ready."
                },
                new Game
                {
                    Id = 5,
                    Name = "The Legend of Zelda: Tears of the Kingdom",
                    Creator = "Nintendo EPD",
                    Year = 2023,
                    IGNRating = 10f,
                    Description = "The follow-up to Breath of the Wild expands Hyrule into the skies and the depths below, and gives Link new abilities to fuse, build and invent his way through puzzles and battles."
                },
                new Game
                {
                    Id = 6,
                    Name = "God of War",
                    Creator = "Santa Monica Studio",
                    Year = 2018,
                    IGNRating = 10f,
                    Description = "Kratos leaves Greece behind for the Norse wilds, journeying with his son Atreus to scatter his late wife's ashes. A heavy-hitting action game with a surprisingly emotional father and son story."
                },
                new Game
                {
                    Id = 7,
                    Name = "The Witcher 3: Wild Hunt",
                    Creator = "CD Projekt Red",
                    Year = 2015,
                    IGNRating = 9.3f,
                    Description = "Monster hunter Geralt of Rivia searches a war-torn continent for his adopted daughter. Known for its memorable side quests, tough choices and a massive, lived-in world."
                },
                new Game
                {
                    Id = 8,
                    Name = "The Elder Scrolls V: Skyrim",
                    Creator = "Bethesda Game Studios",
                    Year = 2011,
                    IGNRating = 9.5f,
                    Description = "As the Dragonborn, explore the frozen province of Skyrim, learn the language of dragons and forge your own path through guilds, civil war and countless dungeons."
                },
                new Game
                {
                    Id = 9,
                    Name = "Grand Theft Auto V",
                    Creator = "Rockstar North",
                    Year = 2013,
                    IGNRating = 10f,
                    Description = "Three very different criminals pull off daring heists across the sprawling city of Los Santos. Switch between characters on the fly in one of the most detailed open worlds ever made."
                },
                new Game
                {
                    Id = 10,
                    Name = "The Last of Us Part II",
                    Creator = "Naughty Dog",
                    Year = 2020,
                    IGNRating = 10f,
                    Description = "Five years after the events of the first game, Ellie sets out on a relentless journey for revenge through a ruined Seattle. Tense stealth, brutal combat and a story that sticks with you."
                },
                new Game
                {
                    Id = 11,
                    Name = "Baldur's Gate 3",
                    Creator = "Larian Studios",
                    Year = 2023,
                    IGNRating = 10f,
                    Description = "A deep, choice-driven RPG built on Dungeons & Dragons rules. Recruit a party, roll the dice in turn-based combat and shape a story that reacts to almost everything you do."
                },
                new Game
                {
                    Id = 12,
                    Name = "Cyberpunk 2077",
                    Creator = "CD Projekt Red",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Play as V, a mercenary chasing an implant that grants immortality in the neon-soaked megacity of Night City. First-person action with RPG depth and lots of ways to approach every job."
                },
                new Game
                {
                    Id = 13,
                    Name = "Halo Infinite",
                    Creator = "343 Industries",
                    Year = 2021,
                    IGNRating = 9f,
                    Description = "Master Chief returns in the most open Halo campaign yet, along with a free-to-play multiplayer mode built around the series' classic arena shooting."
                },
                new Game
                {
                    Id = 14,
                    Name = "Hades",
                    Creator = "Supergiant Games",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Zagreus, son of Hades, battles his way out of the Underworld with help from the gods of Olympus. A fast roguelike where every failed run pushes the story forward."
                },
                new Game
                {
                    Id = 15,
                    Name = "Ghost of Tsushima",
                    Creator = "Sucker Punch Productions",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Samurai Jin Sakai fights to free Tsushima Island from the Mongol invasion, balancing honor against the stealthy tactics of the Ghost in a beautiful open world."
                },
                new Game
                {
                    Id = 16,
                    Name = "Marvel's Spider-Man",
                    Creator = "Insomniac Games",
                    Year = 2018,
                    IGNRating = 8.7f,
                    Description = "An experienced Peter Parker swings through a detailed Manhattan, juggling crime fighting, a new cast of villains and his everyday life."
                },
                new Game
                {
                    Id = 17,
                    Name = "Sekiro: Shadows Die Twice",
                    Creator = "FromSoftware",
                    Year = 2019,
                    IGNRating = 9.5f,
                    Description = "A shinobi known as Wolf seeks revenge and his kidnapped lord in a reimagined Sengoku-era Japan. Precise sword fighting built around deflecting attacks and breaking enemy posture."
                },
                new Game
                {
                    Id = 18,
                    Name = "Animal Crossing: New Horizons",
                    Creator = "Nintendo EPD",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Move to a deserted island and turn it into your own paradise at a relaxing pace. Fish, craft, decorate and hang out with charming animal neighbors in real time."
                },
                new Game
                {
                    Id = 19,
                    Name = "Hollow Knight",
                    Creator = "Team Cherry",
                    Year = 2017,
                    IGNRating = 9.4f,
                    Description = "Explore the vast, ruined bug kingdom of Hallownest in this hand-drawn action adventure full of secrets, tough bosses and tight platforming."
                },
                new Game
                {
                    Id = 20,
                    Name = "Doom",
                    Creator = "id Software",
                    Year = 2016,
                    IGNRating = 9f,
                    Description = "The Doom Slayer rips and tears through the demonic hordes of Mars and Hell. A fast, aggressive shooter that rewards constant movement."
                },
                new Game
                {
                    Id = 21,
                    Name = "Portal 2",
                    Creator = "Valve",
                    Year = 2011,
                    IGNRating = 9.5f,
                    Description = "Solve mind-bending puzzles with the portal gun as the sarcastic AI GLaDOS and the bumbling robot Wheatley guide you through Aperture Science. Includes a two-player co-op campaign."
                },
                new Game
                {
                    Id = 22,
                    Name = "Super Mario Odyssey",
                    Creator = "Nintendo EPD",
                    Year = 2017,
                    IGNRating = 10f,
                    Description = "Mario travels across colorful kingdoms with Cappy, a sentient hat that lets him capture and control enemies, objects and even a dinosaur."
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
                new { GameCategoryId = 8, GameId = 3, CategoryId = "FAN" },
                new { GameCategoryId = 9, GameId = 4, CategoryId = "D" },
                new { GameCategoryId = 10, GameId = 4, CategoryId = "O" },
                new { GameCategoryId = 11, GameId = 4, CategoryId = "FAN" },
                new { GameCategoryId = 12, GameId = 5, CategoryId = "D" },
                new { GameCategoryId = 13, GameId = 5, CategoryId = "O" },
                new { GameCategoryId = 14, GameId = 5, CategoryId = "FAN" },
                new { GameCategoryId = 15, GameId = 6, CategoryId = "A" },
                new { GameCategoryId = 16, GameId = 6, CategoryId = "D" },
                new { GameCategoryId = 17, GameId = 6, CategoryId = "FAN" },
                new { GameCategoryId = 18, GameId = 7, CategoryId = "RPG" },
                new { GameCategoryId = 19, GameId = 7, CategoryId = "O" },
                new { GameCategoryId = 20, GameId = 7, CategoryId = "FAN" },
                new { GameCategoryId = 21, GameId = 8, CategoryId = "RPG" },
                new { GameCategoryId = 22, GameId = 8, CategoryId = "O" },
                new { GameCategoryId = 23, GameId = 8, CategoryId = "FAN" },
                new { GameCategoryId = 24, GameId = 9, CategoryId = "A" },
                new { GameCategoryId = 25, GameId = 9, CategoryId = "O" },
                new { GameCategoryId = 26, GameId = 9, CategoryId = "S" },
                new { GameCategoryId = 27, GameId = 10, CategoryId = "A" },
                new { GameCategoryId = 28, GameId = 10, CategoryId = "D" },
                new { GameCategoryId = 29, GameId = 10, CategoryId = "S" },
                new { GameCategoryId = 30, GameId = 11, CategoryId = "RPG" },
                new { GameCategoryId = 31, GameId = 11, CategoryId = "STR" },
                new { GameCategoryId = 32, GameId = 11, CategoryId = "FAN" },
                new { GameCategoryId = 33, GameId = 12, CategoryId = "RPG" },
                new { GameCategoryId = 34, GameId = 12, CategoryId = "F" },
                new { GameCategoryId = 35, GameId = 12, CategoryId = "S" },
                new { GameCategoryId = 36, GameId = 13, CategoryId = "S" },
                new { GameCategoryId = 37, GameId = 13, CategoryId = "F" },
                new { GameCategoryId = 38, GameId = 13, CategoryId = "COMP" },
                new { GameCategoryId = 39, GameId = 14, CategoryId = "A" },
                new { GameCategoryId = 40, GameId = 14, CategoryId = "FAN" },
                new { GameCategoryId = 41, GameId = 14, CategoryId = "STR" },
                new { GameCategoryId = 42, GameId = 15, CategoryId = "A" },
                new { GameCategoryId = 43, GameId = 15, CategoryId = "D" },
                new { GameCategoryId = 44, GameId = 15, CategoryId = "O" },
                new { GameCategoryId = 45, GameId = 16, CategoryId = "A" },
                new { GameCategoryId = 46, GameId = 16, CategoryId = "D" },
                new { GameCategoryId = 47, GameId = 16, CategoryId = "O" },
                new { GameCategoryId = 48, GameId = 17, CategoryId = "A" },
                new { GameCategoryId = 49, GameId = 17, CategoryId = "D" },
                new { GameCategoryId = 50, GameId = 17, CategoryId = "FAN" },
                new { GameCategoryId = 51, GameId = 18, CategoryId = "CAS" },
                new { GameCategoryId = 52, GameId = 19, CategoryId = "A" },
                new { GameCategoryId = 53, GameId = 19, CategoryId = "D" },
                new { GameCategoryId = 54, GameId = 19, CategoryId = "FAN" },
                new { GameCategoryId = 55, GameId = 20, CategoryId = "S" },
                new { GameCategoryId = 56, GameId = 20, CategoryId = "A" },
                new { GameCategoryId = 57, GameId = 20, CategoryId = "F" },
                new { GameCategoryId = 58, GameId = 21, CategoryId = "C" },
                new { GameCategoryId = 59, GameId = 21, CategoryId = "F" },
                new { GameCategoryId = 60, GameId = 22, CategoryId = "D" },
                new { GameCategoryId = 61, GameId = 22, CategoryId = "CAS" }
            );

            modelBuilder.Entity<Review>().HasData(
                new { ReviewId = 1, GameId = 1, GameRating = 9.3f, GameReview = "This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly recommend this game to anyone who likes a semi-casual shooter with amazing graphics and a great story." },
                new { ReviewId = 2, GameId = 2, GameRating = 7.5f, GameReview = "Starfield is a cool space experience with quite a bit to offer. It has game physics that will keep you interested, but I have a hard time wanting to follow the story. I'd rather just explore the vastness of space." },
                new { ReviewId = 3, GameId = 2, GameRating = 9.3f, GameReview = "BEST GAME EVER I LOVE SPACE" },
                new { ReviewId = 4, GameId = 3, GameRating = 9f, GameReview = "Elden Ring is a gorgeous open world game, with seamless graphics and fighting mechanics. It is a beautifully made game, though it is very difficult!" },
                new { ReviewId = 5, GameId = 1, GameRating = 10f, GameReview = "Arthur Morgan is one of the best characters in gaming. I finished the story months ago and I still think about that ending." },
                new { ReviewId = 6, GameId = 1, GameRating = 8f, GameReview = "Gorgeous and incredibly detailed, but the slow animations and long rides between missions test my patience sometimes." },
                new { ReviewId = 7, GameId = 2, GameRating = 6f, GameReview = "Building ships is fun, but too many loading screens break up the feeling of exploring. Planets start to feel empty after a while." },
                new { ReviewId = 8, GameId = 3, GameRating = 10f, GameReview = "Every corner hides something new. Finally beating Malenia after 60 tries was one of the best feelings I've had playing a game." },
                new { ReviewId = 9, GameId = 3, GameRating = 8.5f, GameReview = "Amazing world, but the difficulty spikes are real. Summoning spirit ashes saved my sanity." },
                new { ReviewId = 10, GameId = 4, GameRating = 10f, GameReview = "The feeling of seeing something on the horizon and just going there never gets old. It completely changed how I think about open worlds." },
                new { ReviewId = 11, GameId = 4, GameRating = 9f, GameReview = "Loved the freedom and the physics, but weapons breaking constantly got annoying." },
                new { ReviewId = 12, GameId = 4, GameRating = 9.5f, GameReview = "Played it on launch day and again last year. It still holds up." },
                new { ReviewId = 13, GameId = 5, GameRating = 10f, GameReview = "Ultrahand is genius. I spent way too long building ridiculous vehicles instead of doing the main quest." },
                new { ReviewId = 14, GameId = 5, GameRating = 9f, GameReview = "Takes everything from Breath of the Wild and adds more. The Depths were a great surprise." },
                new { ReviewId = 15, GameId = 5, GameRating = 8.5f, GameReview = "Fantastic, but it felt a bit too familiar at the start since it reuses the same map." },
                new { ReviewId = 16, GameId = 6, GameRating = 10f, GameReview = "The one-shot camera and the story between Kratos and Atreus got me. Combat with the axe feels amazing." },
                new { ReviewId = 17, GameId = 6, GameRating = 9f, GameReview = "Great boss fights and a beautiful world. I wish there were more enemy types." },
                new { ReviewId = 18, GameId = 7, GameRating = 10f, GameReview = "The Bloody Baron quest alone is better than most full games. Best side quests ever made." },
                new { ReviewId = 19, GameId = 7, GameRating = 9f, GameReview = "Huge and rich world. Combat is a little clunky, but the writing makes up for it." },
                new { ReviewId = 20, GameId = 7, GameRating = 9.5f, GameReview = "Get the expansions too. Blood and Wine is basically its own amazing game." },
                new { ReviewId = 21, GameId = 8, GameRating = 9.5f, GameReview = "I've bought this game on four different consoles. Still finding new caves and quests." },
                new { ReviewId = 22, GameId = 8, GameRating = 8f, GameReview = "Timeless, but the combat feels dated now. Mods fix a lot of it on PC." },
                new { ReviewId = 23, GameId = 8, GameRating = 9f, GameReview = "Fus Ro Dah never gets old." },
                new { ReviewId = 24, GameId = 9, GameRating = 9.5f, GameReview = "The heists are so much fun, and switching between the three characters is a clever idea." },
                new { ReviewId = 25, GameId = 9, GameRating = 8.5f, GameReview = "Story mode is great. Online is fun with friends but grindy on your own." },
                new { ReviewId = 26, GameId = 9, GameRating = 9f, GameReview = "Over ten years later and Los Santos still feels alive." },
                new { ReviewId = 27, GameId = 10, GameRating = 10f, GameReview = "Hard to play at times, but that's the point. The acting and the level of detail are unmatched." },
                new { ReviewId = 28, GameId = 10, GameRating = 7.5f, GameReview = "Incredible gameplay and graphics. I didn't love every choice the story made, but I respect it." },
                new { ReviewId = 29, GameId = 10, GameRating = 9f, GameReview = "The stealth and combat are a big step up from the first game. Some of the best encounters I've played." },
                new { ReviewId = 30, GameId = 11, GameRating = 10f, GameReview = "Every choice matters. My second playthrough felt like a completely different game." },
                new { ReviewId = 31, GameId = 11, GameRating = 9.5f, GameReview = "Turn-based combat was new to me and I ended up loving it. Great companions too." },
                new { ReviewId = 32, GameId = 11, GameRating = 9f, GameReview = "Act 1 is perfect. Act 3 has some performance issues, but it's still amazing." },
                new { ReviewId = 33, GameId = 12, GameRating = 9f, GameReview = "After the updates this is a completely different game. Night City looks unreal." },
                new { ReviewId = 34, GameId = 12, GameRating = 6.5f, GameReview = "Played at launch and it was rough. Came back later and it's much better now." },
                new { ReviewId = 35, GameId = 12, GameRating = 8.5f, GameReview = "Phantom Liberty is some of the best DLC I've ever played." },
                new { ReviewId = 36, GameId = 13, GameRating = 8.5f, GameReview = "Multiplayer feels like classic Halo again. The grappleshot is a blast." },
                new { ReviewId = 37, GameId = 13, GameRating = 7.5f, GameReview = "Good campaign, but the open world gets repetitive by the end." },
                new { ReviewId = 38, GameId = 14, GameRating = 10f, GameReview = "The best roguelike I've played. Every death actually moves the story forward, which keeps you coming back." },
                new { ReviewId = 39, GameId = 14, GameRating = 9f, GameReview = "Great art, great music and characters you actually care about." },
                new { ReviewId = 40, GameId = 14, GameRating = 9.5f, GameReview = "I said 'one more run' at 11pm and suddenly it was 3am." },
                new { ReviewId = 41, GameId = 15, GameRating = 9f, GameReview = "Using the wind to guide you instead of a map marker is such a beautiful idea. Stunning game." },
                new { ReviewId = 42, GameId = 15, GameRating = 8.5f, GameReview = "Sword fights feel fantastic. Side content gets a little repetitive, but it's worth it." },
                new { ReviewId = 43, GameId = 16, GameRating = 9f, GameReview = "Swinging through the city is so smooth that I barely used fast travel." },
                new { ReviewId = 44, GameId = 16, GameRating = 8f, GameReview = "Great story and combat. The stealth sections were a little weak." },
                new { ReviewId = 45, GameId = 17, GameRating = 9.5f, GameReview = "Once the deflect system clicked, fights started to feel like a dance. Brutal but fair." },
                new { ReviewId = 46, GameId = 17, GameRating = 8f, GameReview = "Too hard for me at first, but beating Genichiro felt incredible." },
                new { ReviewId = 47, GameId = 17, GameRating = 10f, GameReview = "FromSoftware's best combat, hands down." },
                new { ReviewId = 48, GameId = 18, GameRating = 9f, GameReview = "My go-to game for winding down after work. My island is finally perfect." },
                new { ReviewId = 49, GameId = 18, GameRating = 8f, GameReview = "Very relaxing, but waiting a real day for things to happen takes patience." },
                new { ReviewId = 50, GameId = 18, GameRating = 9.5f, GameReview = "Got me through 2020. Checking the turnip prices was a daily ritual." },
                new { ReviewId = 51, GameId = 19, GameRating = 9.5f, GameReview = "Huge amount of content for such a small price. The art style and music are beautiful." },
                new { ReviewId = 52, GameId = 19, GameRating = 9f, GameReview = "Tough bosses and lots of backtracking, but exploring Hallownest is worth it." },
                new { ReviewId = 53, GameId = 19, GameRating = 10f, GameReview = "One of the best Metroidvanias ever made." },
                new { ReviewId = 54, GameId = 20, GameRating = 9.5f, GameReview = "Pure adrenaline. The soundtrack makes you feel unstoppable." },
                new { ReviewId = 55, GameId = 20, GameRating = 8.5f, GameReview = "The campaign is fantastic. Multiplayer is forgettable, but who cares." },
                new { ReviewId = 56, GameId = 21, GameRating = 10f, GameReview = "Funniest game I've ever played. GLaDOS and Wheatley are perfect." },
                new { ReviewId = 57, GameId = 21, GameRating = 9.5f, GameReview = "Co-op with a friend is a must. The puzzles are clever without being frustrating." },
                new { ReviewId = 58, GameId = 21, GameRating = 9f, GameReview = "Short, but every minute is great." },
                new { ReviewId = 59, GameId = 22, GameRating = 9.5f, GameReview = "Pure joy from start to finish. Capturing a T-Rex never gets old." },
                new { ReviewId = 60, GameId = 22, GameRating = 9f, GameReview = "Lots of moons to find and every kingdom feels different. Perfect for all ages." }
            );
        }
    }
}
