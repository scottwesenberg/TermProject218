using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllGamesGameReviews.Migrations
{
    /// <inheritdoc />
    public partial class AggroSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin.");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Creator", "Description", "IGNRating", "Name", "Year" },
                values: new object[,]
                {
                    { 4, "Nintendo EPD", "Link wakes from a century-long sleep to find Hyrule in ruins. Climb, glide and explore a huge open world at your own pace, solving shrines and taking on Calamity Ganon whenever you feel ready.", 10f, "The Legend of Zelda: Breath of the Wild", 2017 },
                    { 5, "Nintendo EPD", "The follow-up to Breath of the Wild expands Hyrule into the skies and the depths below, and gives Link new abilities to fuse, build and invent his way through puzzles and battles.", 10f, "The Legend of Zelda: Tears of the Kingdom", 2023 },
                    { 6, "Santa Monica Studio", "Kratos leaves Greece behind for the Norse wilds, journeying with his son Atreus to scatter his late wife's ashes. A heavy-hitting action game with a surprisingly emotional father and son story.", 10f, "God of War", 2018 },
                    { 7, "CD Projekt Red", "Monster hunter Geralt of Rivia searches a war-torn continent for his adopted daughter. Known for its memorable side quests, tough choices and a massive, lived-in world.", 9.3f, "The Witcher 3: Wild Hunt", 2015 },
                    { 8, "Bethesda Game Studios", "As the Dragonborn, explore the frozen province of Skyrim, learn the language of dragons and forge your own path through guilds, civil war and countless dungeons.", 9.5f, "The Elder Scrolls V: Skyrim", 2011 },
                    { 9, "Rockstar North", "Three very different criminals pull off daring heists across the sprawling city of Los Santos. Switch between characters on the fly in one of the most detailed open worlds ever made.", 10f, "Grand Theft Auto V", 2013 },
                    { 10, "Naughty Dog", "Five years after the events of the first game, Ellie sets out on a relentless journey for revenge through a ruined Seattle. Tense stealth, brutal combat and a story that sticks with you.", 10f, "The Last of Us Part II", 2020 },
                    { 11, "Larian Studios", "A deep, choice-driven RPG built on Dungeons & Dragons rules. Recruit a party, roll the dice in turn-based combat and shape a story that reacts to almost everything you do.", 10f, "Baldur's Gate 3", 2023 },
                    { 12, "CD Projekt Red", "Play as V, a mercenary chasing an implant that grants immortality in the neon-soaked megacity of Night City. First-person action with RPG depth and lots of ways to approach every job.", 9f, "Cyberpunk 2077", 2020 },
                    { 13, "343 Industries", "Master Chief returns in the most open Halo campaign yet, along with a free-to-play multiplayer mode built around the series' classic arena shooting.", 9f, "Halo Infinite", 2021 },
                    { 14, "Supergiant Games", "Zagreus, son of Hades, battles his way out of the Underworld with help from the gods of Olympus. A fast roguelike where every failed run pushes the story forward.", 9f, "Hades", 2020 },
                    { 15, "Sucker Punch Productions", "Samurai Jin Sakai fights to free Tsushima Island from the Mongol invasion, balancing honor against the stealthy tactics of the Ghost in a beautiful open world.", 9f, "Ghost of Tsushima", 2020 },
                    { 16, "Insomniac Games", "An experienced Peter Parker swings through a detailed Manhattan, juggling crime fighting, a new cast of villains and his everyday life.", 8.7f, "Marvel's Spider-Man", 2018 },
                    { 17, "FromSoftware", "A shinobi known as Wolf seeks revenge and his kidnapped lord in a reimagined Sengoku-era Japan. Precise sword fighting built around deflecting attacks and breaking enemy posture.", 9.5f, "Sekiro: Shadows Die Twice", 2019 },
                    { 18, "Nintendo EPD", "Move to a deserted island and turn it into your own paradise at a relaxing pace. Fish, craft, decorate and hang out with charming animal neighbors in real time.", 9f, "Animal Crossing: New Horizons", 2020 },
                    { 19, "Team Cherry", "Explore the vast, ruined bug kingdom of Hallownest in this hand-drawn action adventure full of secrets, tough bosses and tight platforming.", 9.4f, "Hollow Knight", 2017 },
                    { 20, "id Software", "The Doom Slayer rips and tears through the demonic hordes of Mars and Hell. A fast, aggressive shooter that rewards constant movement.", 9f, "Doom", 2016 },
                    { 21, "Valve", "Solve mind-bending puzzles with the portal gun as the sarcastic AI GLaDOS and the bumbling robot Wheatley guide you through Aperture Science. Includes a two-player co-op campaign.", 9.5f, "Portal 2", 2011 },
                    { 22, "Nintendo EPD", "Mario travels across colorful kingdoms with Cappy, a sentient hat that lets him capture and control enemies, objects and even a dinosaur.", 10f, "Super Mario Odyssey", 2017 }
                });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "GameReview",
                value: "This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly recommend this game to anyone who likes a semi-casual shooter with amazing graphics and a great story.");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "GameReview",
                value: "Starfield is a cool space experience with quite a bit to offer. It has game physics that will keep you interested, but I have a hard time wanting to follow the story. I'd rather just explore the vastness of space.");

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "GameId", "GameRating", "GameReview" },
                values: new object[,]
                {
                    { 5, 1, 10f, "Arthur Morgan is one of the best characters in gaming. I finished the story months ago and I still think about that ending." },
                    { 6, 1, 8f, "Gorgeous and incredibly detailed, but the slow animations and long rides between missions test my patience sometimes." },
                    { 7, 2, 6f, "Building ships is fun, but too many loading screens break up the feeling of exploring. Planets start to feel empty after a while." },
                    { 8, 3, 10f, "Every corner hides something new. Finally beating Malenia after 60 tries was one of the best feelings I've had playing a game." },
                    { 9, 3, 8.5f, "Amazing world, but the difficulty spikes are real. Summoning spirit ashes saved my sanity." }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "GameCategoryId", "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 9, "D", 4 },
                    { 10, "O", 4 },
                    { 11, "FAN", 4 },
                    { 12, "D", 5 },
                    { 13, "O", 5 },
                    { 14, "FAN", 5 },
                    { 15, "A", 6 },
                    { 16, "D", 6 },
                    { 17, "FAN", 6 },
                    { 18, "RPG", 7 },
                    { 19, "O", 7 },
                    { 20, "FAN", 7 },
                    { 21, "RPG", 8 },
                    { 22, "O", 8 },
                    { 23, "FAN", 8 },
                    { 24, "A", 9 },
                    { 25, "O", 9 },
                    { 26, "S", 9 },
                    { 27, "A", 10 },
                    { 28, "D", 10 },
                    { 29, "S", 10 },
                    { 30, "RPG", 11 },
                    { 31, "STR", 11 },
                    { 32, "FAN", 11 },
                    { 33, "RPG", 12 },
                    { 34, "F", 12 },
                    { 35, "S", 12 },
                    { 36, "S", 13 },
                    { 37, "F", 13 },
                    { 38, "COMP", 13 },
                    { 39, "A", 14 },
                    { 40, "FAN", 14 },
                    { 41, "STR", 14 },
                    { 42, "A", 15 },
                    { 43, "D", 15 },
                    { 44, "O", 15 },
                    { 45, "A", 16 },
                    { 46, "D", 16 },
                    { 47, "O", 16 },
                    { 48, "A", 17 },
                    { 49, "D", 17 },
                    { 50, "FAN", 17 },
                    { 51, "CAS", 18 },
                    { 52, "A", 19 },
                    { 53, "D", 19 },
                    { 54, "FAN", 19 },
                    { 55, "S", 20 },
                    { 56, "A", 20 },
                    { 57, "F", 20 },
                    { 58, "C", 21 },
                    { 59, "F", 21 },
                    { 60, "D", 22 },
                    { 61, "CAS", 22 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "GameId", "GameRating", "GameReview" },
                values: new object[,]
                {
                    { 10, 4, 10f, "The feeling of seeing something on the horizon and just going there never gets old. It completely changed how I think about open worlds." },
                    { 11, 4, 9f, "Loved the freedom and the physics, but weapons breaking constantly got annoying." },
                    { 12, 4, 9.5f, "Played it on launch day and again last year. It still holds up." },
                    { 13, 5, 10f, "Ultrahand is genius. I spent way too long building ridiculous vehicles instead of doing the main quest." },
                    { 14, 5, 9f, "Takes everything from Breath of the Wild and adds more. The Depths were a great surprise." },
                    { 15, 5, 8.5f, "Fantastic, but it felt a bit too familiar at the start since it reuses the same map." },
                    { 16, 6, 10f, "The one-shot camera and the story between Kratos and Atreus got me. Combat with the axe feels amazing." },
                    { 17, 6, 9f, "Great boss fights and a beautiful world. I wish there were more enemy types." },
                    { 18, 7, 10f, "The Bloody Baron quest alone is better than most full games. Best side quests ever made." },
                    { 19, 7, 9f, "Huge and rich world. Combat is a little clunky, but the writing makes up for it." },
                    { 20, 7, 9.5f, "Get the expansions too. Blood and Wine is basically its own amazing game." },
                    { 21, 8, 9.5f, "I've bought this game on four different consoles. Still finding new caves and quests." },
                    { 22, 8, 8f, "Timeless, but the combat feels dated now. Mods fix a lot of it on PC." },
                    { 23, 8, 9f, "Fus Ro Dah never gets old." },
                    { 24, 9, 9.5f, "The heists are so much fun, and switching between the three characters is a clever idea." },
                    { 25, 9, 8.5f, "Story mode is great. Online is fun with friends but grindy on your own." },
                    { 26, 9, 9f, "Over ten years later and Los Santos still feels alive." },
                    { 27, 10, 10f, "Hard to play at times, but that's the point. The acting and the level of detail are unmatched." },
                    { 28, 10, 7.5f, "Incredible gameplay and graphics. I didn't love every choice the story made, but I respect it." },
                    { 29, 10, 9f, "The stealth and combat are a big step up from the first game. Some of the best encounters I've played." },
                    { 30, 11, 10f, "Every choice matters. My second playthrough felt like a completely different game." },
                    { 31, 11, 9.5f, "Turn-based combat was new to me and I ended up loving it. Great companions too." },
                    { 32, 11, 9f, "Act 1 is perfect. Act 3 has some performance issues, but it's still amazing." },
                    { 33, 12, 9f, "After the updates this is a completely different game. Night City looks unreal." },
                    { 34, 12, 6.5f, "Played at launch and it was rough. Came back later and it's much better now." },
                    { 35, 12, 8.5f, "Phantom Liberty is some of the best DLC I've ever played." },
                    { 36, 13, 8.5f, "Multiplayer feels like classic Halo again. The grappleshot is a blast." },
                    { 37, 13, 7.5f, "Good campaign, but the open world gets repetitive by the end." },
                    { 38, 14, 10f, "The best roguelike I've played. Every death actually moves the story forward, which keeps you coming back." },
                    { 39, 14, 9f, "Great art, great music and characters you actually care about." },
                    { 40, 14, 9.5f, "I said 'one more run' at 11pm and suddenly it was 3am." },
                    { 41, 15, 9f, "Using the wind to guide you instead of a map marker is such a beautiful idea. Stunning game." },
                    { 42, 15, 8.5f, "Sword fights feel fantastic. Side content gets a little repetitive, but it's worth it." },
                    { 43, 16, 9f, "Swinging through the city is so smooth that I barely used fast travel." },
                    { 44, 16, 8f, "Great story and combat. The stealth sections were a little weak." },
                    { 45, 17, 9.5f, "Once the deflect system clicked, fights started to feel like a dance. Brutal but fair." },
                    { 46, 17, 8f, "Too hard for me at first, but beating Genichiro felt incredible." },
                    { 47, 17, 10f, "FromSoftware's best combat, hands down." },
                    { 48, 18, 9f, "My go-to game for winding down after work. My island is finally perfect." },
                    { 49, 18, 8f, "Very relaxing, but waiting a real day for things to happen takes patience." },
                    { 50, 18, 9.5f, "Got me through 2020. Checking the turnip prices was a daily ritual." },
                    { 51, 19, 9.5f, "Huge amount of content for such a small price. The art style and music are beautiful." },
                    { 52, 19, 9f, "Tough bosses and lots of backtracking, but exploring Hallownest is worth it." },
                    { 53, 19, 10f, "One of the best Metroidvanias ever made." },
                    { 54, 20, 9.5f, "Pure adrenaline. The soundtrack makes you feel unstoppable." },
                    { 55, 20, 8.5f, "The campaign is fantastic. Multiplayer is forgettable, but who cares." },
                    { 56, 21, 10f, "Funniest game I've ever played. GLaDOS and Wheatley are perfect." },
                    { 57, 21, 9.5f, "Co-op with a friend is a must. The puzzles are clever without being frustrating." },
                    { 58, 21, 9f, "Short, but every minute is great." },
                    { 59, 22, 9.5f, "Pure joy from start to finish. Capturing a T-Rex never gets old." },
                    { 60, 22, 9f, "Lots of moons to find and every kingdom feels different. Perfect for all ages." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout.");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "GameReview",
                value: "This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly reccomend this game to anyone who likes a semi-casual shooter with amazing graphics and a gret story.");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2,
                column: "GameReview",
                value: "Starfield is a cool space experiece with quite a bit to offer. It has game physics that will keep you insterested, but I have a hard time wanting to follow to story. I'd rather just explore the vastness of space.");
        }
    }
}
