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
                    Description = "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game's vast and atmospheric world also provides the foundation for a brand new online multiplayer experience.",
                    ImageUrl = "/images/games/red-dead-redemption-2.jpg"
                },
                new Game
                {
                    Id = 2,
                    Name = "Starfield",
                    Creator = "Bethesda Game Studios",
                    Year = 2023,
                    IGNRating = 7f,
                    Description = "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout.",
                    ImageUrl = "/images/games/starfield.jpg"
                },
                new Game
                {
                    Id = 3,
                    Name = "Elden Ring",
                    Creator = "FromSoftware",
                    Year = 2022,
                    IGNRating = 10f,
                    Description = "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin.",
                    ImageUrl = "/images/games/elden-ring.jpg"
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
                    Description = "Kratos leaves Greece behind for the Norse wilds, journeying with his son Atreus to scatter his late wife's ashes. A heavy-hitting action game with a surprisingly emotional father and son story.",
                    ImageUrl = "/images/games/god-of-war.jpg"
                },
                new Game
                {
                    Id = 7,
                    Name = "The Witcher 3: Wild Hunt",
                    Creator = "CD Projekt Red",
                    Year = 2015,
                    IGNRating = 9.3f,
                    Description = "Monster hunter Geralt of Rivia searches a war-torn continent for his adopted daughter. Known for its memorable side quests, tough choices and a massive, lived-in world.",
                    ImageUrl = "/images/games/the-witcher-3-wild-hunt.jpg"
                },
                new Game
                {
                    Id = 8,
                    Name = "The Elder Scrolls V: Skyrim",
                    Creator = "Bethesda Game Studios",
                    Year = 2011,
                    IGNRating = 9.5f,
                    Description = "As the Dragonborn, explore the frozen province of Skyrim, learn the language of dragons and forge your own path through guilds, civil war and countless dungeons.",
                    ImageUrl = "/images/games/the-elder-scrolls-v-skyrim.jpg"
                },
                new Game
                {
                    Id = 9,
                    Name = "Grand Theft Auto V",
                    Creator = "Rockstar North",
                    Year = 2013,
                    IGNRating = 10f,
                    Description = "Three very different criminals pull off daring heists across the sprawling city of Los Santos. Switch between characters on the fly in one of the most detailed open worlds ever made.",
                    ImageUrl = "/images/games/grand-theft-auto-v.jpg"
                },
                new Game
                {
                    Id = 10,
                    Name = "The Last of Us Part II",
                    Creator = "Naughty Dog",
                    Year = 2020,
                    IGNRating = 10f,
                    Description = "Five years after the events of the first game, Ellie sets out on a relentless journey for revenge through a ruined Seattle. Tense stealth, brutal combat and a story that sticks with you.",
                    ImageUrl = "/images/games/the-last-of-us-part-ii.jpg"
                },
                new Game
                {
                    Id = 11,
                    Name = "Baldur's Gate 3",
                    Creator = "Larian Studios",
                    Year = 2023,
                    IGNRating = 10f,
                    Description = "A deep, choice-driven RPG built on Dungeons & Dragons rules. Recruit a party, roll the dice in turn-based combat and shape a story that reacts to almost everything you do.",
                    ImageUrl = "/images/games/baldur-s-gate-3.jpg"
                },
                new Game
                {
                    Id = 12,
                    Name = "Cyberpunk 2077",
                    Creator = "CD Projekt Red",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Play as V, a mercenary chasing an implant that grants immortality in the neon-soaked megacity of Night City. First-person action with RPG depth and lots of ways to approach every job.",
                    ImageUrl = "/images/games/cyberpunk-2077.jpg"
                },
                new Game
                {
                    Id = 13,
                    Name = "Halo Infinite",
                    Creator = "343 Industries",
                    Year = 2021,
                    IGNRating = 9f,
                    Description = "Master Chief returns in the most open Halo campaign yet, along with a free-to-play multiplayer mode built around the series' classic arena shooting.",
                    ImageUrl = "/images/games/halo-infinite.jpg"
                },
                new Game
                {
                    Id = 14,
                    Name = "Hades",
                    Creator = "Supergiant Games",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Zagreus, son of Hades, battles his way out of the Underworld with help from the gods of Olympus. A fast roguelike where every failed run pushes the story forward.",
                    ImageUrl = "/images/games/hades.jpg"
                },
                new Game
                {
                    Id = 15,
                    Name = "Ghost of Tsushima",
                    Creator = "Sucker Punch Productions",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Samurai Jin Sakai fights to free Tsushima Island from the Mongol invasion, balancing honor against the stealthy tactics of the Ghost in a beautiful open world.",
                    ImageUrl = "/images/games/ghost-of-tsushima.jpg"
                },
                new Game
                {
                    Id = 16,
                    Name = "Marvel's Spider-Man",
                    Creator = "Insomniac Games",
                    Year = 2018,
                    IGNRating = 8.7f,
                    Description = "An experienced Peter Parker swings through a detailed Manhattan, juggling crime fighting, a new cast of villains and his everyday life.",
                    ImageUrl = "/images/games/marvel-s-spider-man.jpg"
                },
                new Game
                {
                    Id = 17,
                    Name = "Sekiro: Shadows Die Twice",
                    Creator = "FromSoftware",
                    Year = 2019,
                    IGNRating = 9.5f,
                    Description = "A shinobi known as Wolf seeks revenge and his kidnapped lord in a reimagined Sengoku-era Japan. Precise sword fighting built around deflecting attacks and breaking enemy posture.",
                    ImageUrl = "/images/games/sekiro-shadows-die-twice.jpg"
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
                    Description = "Explore the vast, ruined bug kingdom of Hallownest in this hand-drawn action adventure full of secrets, tough bosses and tight platforming.",
                    ImageUrl = "/images/games/hollow-knight.jpg"
                },
                new Game
                {
                    Id = 20,
                    Name = "Doom",
                    Creator = "id Software",
                    Year = 2016,
                    IGNRating = 9f,
                    Description = "The Doom Slayer rips and tears through the demonic hordes of Mars and Hell. A fast, aggressive shooter that rewards constant movement.",
                    ImageUrl = "/images/games/doom.jpg"
                },
                new Game
                {
                    Id = 21,
                    Name = "Portal 2",
                    Creator = "Valve",
                    Year = 2011,
                    IGNRating = 9.5f,
                    Description = "Solve mind-bending puzzles with the portal gun as the sarcastic AI GLaDOS and the bumbling robot Wheatley guide you through Aperture Science. Includes a two-player co-op campaign.",
                    ImageUrl = "/images/games/portal-2.jpg"
                },
                new Game
                {
                    Id = 22,
                    Name = "Super Mario Odyssey",
                    Creator = "Nintendo EPD",
                    Year = 2017,
                    IGNRating = 10f,
                    Description = "Mario travels across colorful kingdoms with Cappy, a sentient hat that lets him capture and control enemies, objects and even a dinosaur."
                },
                new Game
                {
                    Id = 23,
                    Name = "Mass Effect 2",
                    Creator = "BioWare",
                    Year = 2010,
                    IGNRating = 9.6f,
                    Description = "Commander Shepard assembles a squad of specialists for a suicide mission against the Collectors. Choices from the first game carry over, and every squadmate's loyalty matters."
                },
                new Game
                {
                    Id = 24,
                    Name = "BioShock",
                    Creator = "2K Boston",
                    Year = 2007,
                    IGNRating = 9.7f,
                    Description = "Explore Rapture, a crumbling underwater city built on extreme ideals. Combine plasmids and weapons in a shooter famous for its atmosphere and its twist.",
                    ImageUrl = "/images/games/bioshock.jpg"
                },
                new Game
                {
                    Id = 25,
                    Name = "Half-Life 2",
                    Creator = "Valve",
                    Year = 2004,
                    IGNRating = 9.7f,
                    Description = "Gordon Freeman returns to fight the alien Combine in City 17. A groundbreaking shooter known for its physics puzzles and the iconic gravity gun.",
                    ImageUrl = "/images/games/half-life-2.jpg"
                },
                new Game
                {
                    Id = 26,
                    Name = "Super Mario Galaxy",
                    Creator = "Nintendo EAD Tokyo",
                    Year = 2007,
                    IGNRating = 9.7f,
                    Description = "Mario blasts off into space, running around tiny planets with their own gravity to rescue Princess Peach from Bowser."
                },
                new Game
                {
                    Id = 27,
                    Name = "Resident Evil 4",
                    Creator = "Capcom",
                    Year = 2005,
                    IGNRating = 9.8f,
                    Description = "Agent Leon S. Kennedy heads to rural Spain to rescue the president's daughter from a mysterious cult. The over-the-shoulder camera changed action games forever.",
                    ImageUrl = "/images/games/resident-evil-4.jpg"
                },
                new Game
                {
                    Id = 28,
                    Name = "Metal Gear Solid V: The Phantom Pain",
                    Creator = "Kojima Productions",
                    Year = 2015,
                    IGNRating = 10f,
                    Description = "Venom Snake builds a private army and takes on missions across Afghanistan and Africa, with total freedom in how you sneak, fight or improvise.",
                    ImageUrl = "/images/games/metal-gear-solid-v-the-phantom-pain.jpg"
                },
                new Game
                {
                    Id = 29,
                    Name = "Uncharted 2: Among Thieves",
                    Creator = "Naughty Dog",
                    Year = 2009,
                    IGNRating = 9.5f,
                    Description = "Treasure hunter Nathan Drake races to find the lost city of Shambhala in a cinematic adventure full of set pieces, climbing and shootouts."
                },
                new Game
                {
                    Id = 30,
                    Name = "The Last of Us",
                    Creator = "Naughty Dog",
                    Year = 2013,
                    IGNRating = 10f,
                    Description = "Smuggler Joel escorts 14-year-old Ellie across a ruined America twenty years after a fungal outbreak. A survival story driven by one of gaming's best relationships.",
                    ImageUrl = "/images/games/the-last-of-us.jpg"
                },
                new Game
                {
                    Id = 31,
                    Name = "Bloodborne",
                    Creator = "FromSoftware",
                    Year = 2015,
                    IGNRating = 9.1f,
                    Description = "Hunt nightmarish beasts through the gothic city of Yharnam. Faster and more aggressive than Dark Souls, rewarding players who fight back."
                },
                new Game
                {
                    Id = 32,
                    Name = "Super Smash Bros. Ultimate",
                    Creator = "Bandai Namco Studios",
                    Year = 2018,
                    IGNRating = 9.8f,
                    Description = "Every fighter in Smash history returns in one massive crossover brawler. Great for parties and deep enough for competitive play."
                },
                new Game
                {
                    Id = 33,
                    Name = "Mario Kart 8 Deluxe",
                    Creator = "Nintendo EPD",
                    Year = 2017,
                    IGNRating = 9.2f,
                    Description = "The definitive Mario Kart with dozens of tracks, anti-gravity racing and smart steering options so the whole family can play."
                },
                new Game
                {
                    Id = 34,
                    Name = "Overwatch",
                    Creator = "Blizzard Entertainment",
                    Year = 2016,
                    IGNRating = 9.4f,
                    Description = "Team-based hero shooter where every character has unique abilities. Coordinate with your team to push the payload or hold the point."
                },
                new Game
                {
                    Id = 35,
                    Name = "Fallout 4",
                    Creator = "Bethesda Game Studios",
                    Year = 2015,
                    IGNRating = 9.5f,
                    Description = "Emerge from Vault 111 into the post-apocalyptic Commonwealth to search for your missing son. Explore, craft and build settlements across the wasteland.",
                    ImageUrl = "/images/games/fallout-4.jpg"
                },
                new Game
                {
                    Id = 36,
                    Name = "Horizon Zero Dawn",
                    Creator = "Guerrilla Games",
                    Year = 2017,
                    IGNRating = 9.3f,
                    Description = "Aloy hunts giant robotic creatures in a lush world where nature has reclaimed the remains of a lost civilization, and uncovers the truth behind it.",
                    ImageUrl = "/images/games/horizon-zero-dawn.jpg"
                },
                new Game
                {
                    Id = 37,
                    Name = "Death Stranding",
                    Creator = "Kojima Productions",
                    Year = 2019,
                    IGNRating = 6.8f,
                    Description = "Sam Porter Bridges reconnects a fractured America by delivering cargo across dangerous terrain. A strange, divisive game about connection.",
                    ImageUrl = "/images/games/death-stranding.jpg"
                },
                new Game
                {
                    Id = 38,
                    Name = "Batman: Arkham City",
                    Creator = "Rocksteady Studios",
                    Year = 2011,
                    IGNRating = 9.5f,
                    Description = "Batman is trapped inside a walled-off district of Gotham run by his worst enemies. Fluid combat, gadgets and gliding across rooftops.",
                    ImageUrl = "/images/games/batman-arkham-city.jpg"
                },
                new Game
                {
                    Id = 39,
                    Name = "It Takes Two",
                    Creator = "Hazelight Studios",
                    Year = 2021,
                    IGNRating = 9f,
                    Description = "A couple on the verge of divorce is shrunk into dolls and must work together to get home. A creative co-op adventure that changes its gameplay every level.",
                    ImageUrl = "/images/games/it-takes-two.jpg"
                },
                new Game
                {
                    Id = 40,
                    Name = "Apex Legends",
                    Creator = "Respawn Entertainment",
                    Year = 2019,
                    IGNRating = 9f,
                    Description = "Free-to-play battle royale with unique Legends, fast movement and a smart ping system that makes teamwork easy even without voice chat.",
                    ImageUrl = "/images/games/apex-legends.jpg"
                },
                new Game
                {
                    Id = 41,
                    Name = "Diablo IV",
                    Creator = "Blizzard Entertainment",
                    Year = 2023,
                    IGNRating = 9f,
                    Description = "Lilith returns to Sanctuary in a dark action RPG. Build your character, clear dungeons and chase better loot solo or with friends.",
                    ImageUrl = "/images/games/diablo-iv.jpg"
                },
                new Game
                {
                    Id = 42,
                    Name = "Final Fantasy VII Remake",
                    Creator = "Square Enix",
                    Year = 2020,
                    IGNRating = 9f,
                    Description = "Cloud Strife and the rebel group Avalanche fight the Shinra corporation in a reimagined Midgar, with real-time action combat and a new take on the classic story.",
                    ImageUrl = "/images/games/final-fantasy-vii-remake.jpg"
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
                new { GameCategoryId = 61, GameId = 22, CategoryId = "CAS" },
                new { GameCategoryId = 62, GameId = 23, CategoryId = "RPG" },
                new { GameCategoryId = 63, GameId = 23, CategoryId = "F" },
                new { GameCategoryId = 64, GameId = 23, CategoryId = "S" },
                new { GameCategoryId = 65, GameId = 24, CategoryId = "S" },
                new { GameCategoryId = 66, GameId = 24, CategoryId = "F" },
                new { GameCategoryId = 67, GameId = 24, CategoryId = "A" },
                new { GameCategoryId = 68, GameId = 25, CategoryId = "S" },
                new { GameCategoryId = 69, GameId = 25, CategoryId = "F" },
                new { GameCategoryId = 70, GameId = 25, CategoryId = "A" },
                new { GameCategoryId = 71, GameId = 26, CategoryId = "D" },
                new { GameCategoryId = 72, GameId = 26, CategoryId = "CAS" },
                new { GameCategoryId = 73, GameId = 27, CategoryId = "A" },
                new { GameCategoryId = 74, GameId = 27, CategoryId = "S" },
                new { GameCategoryId = 75, GameId = 28, CategoryId = "A" },
                new { GameCategoryId = 76, GameId = 28, CategoryId = "O" },
                new { GameCategoryId = 77, GameId = 28, CategoryId = "STR" },
                new { GameCategoryId = 78, GameId = 29, CategoryId = "A" },
                new { GameCategoryId = 79, GameId = 29, CategoryId = "D" },
                new { GameCategoryId = 80, GameId = 29, CategoryId = "S" },
                new { GameCategoryId = 81, GameId = 30, CategoryId = "A" },
                new { GameCategoryId = 82, GameId = 30, CategoryId = "D" },
                new { GameCategoryId = 83, GameId = 30, CategoryId = "S" },
                new { GameCategoryId = 84, GameId = 31, CategoryId = "A" },
                new { GameCategoryId = 85, GameId = 31, CategoryId = "RPG" },
                new { GameCategoryId = 86, GameId = 31, CategoryId = "FAN" },
                new { GameCategoryId = 87, GameId = 32, CategoryId = "COMP" },
                new { GameCategoryId = 88, GameId = 32, CategoryId = "CAS" },
                new { GameCategoryId = 89, GameId = 32, CategoryId = "A" },
                new { GameCategoryId = 90, GameId = 33, CategoryId = "SPORT" },
                new { GameCategoryId = 91, GameId = 33, CategoryId = "CAS" },
                new { GameCategoryId = 92, GameId = 33, CategoryId = "COMP" },
                new { GameCategoryId = 93, GameId = 34, CategoryId = "S" },
                new { GameCategoryId = 94, GameId = 34, CategoryId = "COMP" },
                new { GameCategoryId = 95, GameId = 34, CategoryId = "F" },
                new { GameCategoryId = 96, GameId = 35, CategoryId = "RPG" },
                new { GameCategoryId = 97, GameId = 35, CategoryId = "O" },
                new { GameCategoryId = 98, GameId = 35, CategoryId = "F" },
                new { GameCategoryId = 99, GameId = 36, CategoryId = "A" },
                new { GameCategoryId = 100, GameId = 36, CategoryId = "O" },
                new { GameCategoryId = 101, GameId = 36, CategoryId = "F" },
                new { GameCategoryId = 102, GameId = 37, CategoryId = "D" },
                new { GameCategoryId = 103, GameId = 37, CategoryId = "O" },
                new { GameCategoryId = 104, GameId = 37, CategoryId = "F" },
                new { GameCategoryId = 105, GameId = 38, CategoryId = "A" },
                new { GameCategoryId = 106, GameId = 38, CategoryId = "D" },
                new { GameCategoryId = 107, GameId = 38, CategoryId = "O" },
                new { GameCategoryId = 108, GameId = 39, CategoryId = "D" },
                new { GameCategoryId = 109, GameId = 39, CategoryId = "C" },
                new { GameCategoryId = 110, GameId = 39, CategoryId = "CAS" },
                new { GameCategoryId = 111, GameId = 40, CategoryId = "S" },
                new { GameCategoryId = 112, GameId = 40, CategoryId = "COMP" },
                new { GameCategoryId = 113, GameId = 41, CategoryId = "RPG" },
                new { GameCategoryId = 114, GameId = 41, CategoryId = "A" },
                new { GameCategoryId = 115, GameId = 41, CategoryId = "FAN" },
                new { GameCategoryId = 116, GameId = 42, CategoryId = "RPG" },
                new { GameCategoryId = 117, GameId = 42, CategoryId = "A" },
                new { GameCategoryId = 118, GameId = 42, CategoryId = "F" }
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
                new { ReviewId = 60, GameId = 22, GameRating = 9f, GameReview = "Lots of moons to find and every kingdom feels different. Perfect for all ages." },
                new { ReviewId = 61, GameId = 23, GameRating = 10f, GameReview = "The suicide mission is the best final act in any RPG. I was nervous about every squadmate." },
                new { ReviewId = 62, GameId = 23, GameRating = 9.5f, GameReview = "Great characters and loyalty missions. Planet scanning was a chore though." },
                new { ReviewId = 63, GameId = 23, GameRating = 9f, GameReview = "Still holds up in the Legendary Edition." },
                new { ReviewId = 64, GameId = 24, GameRating = 10f, GameReview = "Would you kindly play this game? The atmosphere of Rapture is unforgettable." },
                new { ReviewId = 65, GameId = 24, GameRating = 9f, GameReview = "Amazing story and setting. Combat is a bit clunky by today's standards." },
                new { ReviewId = 66, GameId = 25, GameRating = 9.5f, GameReview = "The gravity gun is still one of the most fun weapons in any game." },
                new { ReviewId = 67, GameId = 25, GameRating = 9f, GameReview = "Ravenholm scared me as a kid and still does." },
                new { ReviewId = 68, GameId = 25, GameRating = 8.5f, GameReview = "Some sections drag, but it was way ahead of its time." },
                new { ReviewId = 69, GameId = 26, GameRating = 10f, GameReview = "Pure creativity. Every galaxy feels like a new idea." },
                new { ReviewId = 70, GameId = 26, GameRating = 9.5f, GameReview = "The music is incredible and the gravity mechanics never get old." },
                new { ReviewId = 71, GameId = 27, GameRating = 10f, GameReview = "Perfect pacing from start to finish. The village fight at the start is legendary." },
                new { ReviewId = 72, GameId = 27, GameRating = 9f, GameReview = "Leon's one-liners are cheesy in the best way. Still fun decades later." },
                new { ReviewId = 73, GameId = 27, GameRating = 8.5f, GameReview = "Escort sections with Ashley can be annoying, but everything else is great." },
                new { ReviewId = 74, GameId = 28, GameRating = 10f, GameReview = "The freedom is unmatched. Every outpost can be tackled in a dozen ways." },
                new { ReviewId = 75, GameId = 28, GameRating = 8f, GameReview = "Incredible gameplay, but the story feels unfinished near the end." },
                new { ReviewId = 76, GameId = 28, GameRating = 9f, GameReview = "Fulton-ing sheep back to Mother Base never gets old." },
                new { ReviewId = 77, GameId = 29, GameRating = 9.5f, GameReview = "The train level is one of the best set pieces ever made." },
                new { ReviewId = 78, GameId = 29, GameRating = 9f, GameReview = "Great banter between the characters and gorgeous locations." },
                new { ReviewId = 79, GameId = 30, GameRating = 10f, GameReview = "The ending hit me harder than any movie. Masterpiece." },
                new { ReviewId = 80, GameId = 30, GameRating = 9.5f, GameReview = "Tense, beautiful and heartbreaking. Every encounter feels desperate." },
                new { ReviewId = 81, GameId = 30, GameRating = 9f, GameReview = "Play the remastered version if you can. Still amazing." },
                new { ReviewId = 82, GameId = 31, GameRating = 10f, GameReview = "The best world design FromSoftware has ever done. Yharnam is unforgettable." },
                new { ReviewId = 83, GameId = 31, GameRating = 9f, GameReview = "Fast and aggressive combat that rewards you for being bold." },
                new { ReviewId = 84, GameId = 31, GameRating = 8f, GameReview = "Load times on PS4 hurt, but the game itself is incredible." },
                new { ReviewId = 85, GameId = 32, GameRating = 10f, GameReview = "Everyone is here! Game nights with friends are chaos in the best way." },
                new { ReviewId = 86, GameId = 32, GameRating = 9f, GameReview = "Huge roster and tons of stages. World of Light mode was a nice bonus." },
                new { ReviewId = 87, GameId = 33, GameRating = 9f, GameReview = "Our family's favorite game. Smart steering lets my kids race with us." },
                new { ReviewId = 88, GameId = 33, GameRating = 9.5f, GameReview = "Tons of tracks with the booster pass. Blue shells still hurt." },
                new { ReviewId = 89, GameId = 33, GameRating = 8.5f, GameReview = "Great online races, though some tracks feel too similar." },
                new { ReviewId = 90, GameId = 34, GameRating = 9f, GameReview = "Every hero feels different and the art style is fantastic." },
                new { ReviewId = 91, GameId = 34, GameRating = 8f, GameReview = "So fun with a good team. Frustrating with a bad one." },
                new { ReviewId = 92, GameId = 34, GameRating = 9.5f, GameReview = "Played this nonstop for two years. Great memories." },
                new { ReviewId = 93, GameId = 35, GameRating = 9f, GameReview = "Building settlements took up way more of my time than I expected." },
                new { ReviewId = 94, GameId = 35, GameRating = 8f, GameReview = "Great exploration, but the dialogue system is a step back from earlier Fallouts." },
                new { ReviewId = 95, GameId = 36, GameRating = 9.5f, GameReview = "Fighting robot dinosaurs with a bow is exactly as cool as it sounds." },
                new { ReviewId = 96, GameId = 36, GameRating = 9f, GameReview = "Beautiful world and a surprisingly great sci-fi mystery." },
                new { ReviewId = 97, GameId = 37, GameRating = 8f, GameReview = "Weird, slow and somehow really relaxing. Nothing else is like it." },
                new { ReviewId = 98, GameId = 37, GameRating = 5.5f, GameReview = "Beautiful, but I couldn't get into walking packages across the map for hours." },
                new { ReviewId = 99, GameId = 37, GameRating = 9f, GameReview = "Finding a ladder someone else left for you is such a cool feeling." },
                new { ReviewId = 100, GameId = 38, GameRating = 9.5f, GameReview = "Gliding over Arkham City and taking down thugs never gets old." },
                new { ReviewId = 101, GameId = 38, GameRating = 9f, GameReview = "Great villains and a ton of Riddler challenges to find." },
                new { ReviewId = 102, GameId = 39, GameRating = 10f, GameReview = "Best co-op game I've ever played. Every level has a new idea." },
                new { ReviewId = 103, GameId = 39, GameRating = 9f, GameReview = "Played it with my partner and we loved it. The squirrel fight was hilarious." },
                new { ReviewId = 104, GameId = 39, GameRating = 8.5f, GameReview = "The story is a little cheesy, but the gameplay is brilliant." },
                new { ReviewId = 105, GameId = 40, GameRating = 9f, GameReview = "The movement and gunplay feel amazing, and the ping system is genius." },
                new { ReviewId = 106, GameId = 40, GameRating = 7.5f, GameReview = "Great game, but it can get sweaty fast in ranked." },
                new { ReviewId = 107, GameId = 41, GameRating = 9f, GameReview = "Dark tone, great campaign and satisfying loot." },
                new { ReviewId = 108, GameId = 41, GameRating = 7.5f, GameReview = "The campaign is great, but the endgame needed more when it launched." },
                new { ReviewId = 109, GameId = 41, GameRating = 8.5f, GameReview = "Seasons have improved it a lot. Fun with friends." },
                new { ReviewId = 110, GameId = 42, GameRating = 9f, GameReview = "Combat blends action and strategy perfectly. Midgar looks amazing." },
                new { ReviewId = 111, GameId = 42, GameRating = 8.5f, GameReview = "Some filler sections, but the characters shine." },
                new { ReviewId = 112, GameId = 42, GameRating = 9.5f, GameReview = "Hearing the classic music remade brought back so many memories." }
            );
        }
    }
}
