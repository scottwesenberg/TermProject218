using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllGamesGameReviews.Migrations
{
    /// <inheritdoc />
    public partial class AddGameImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Games",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 22,
                column: "ImageUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Creator", "Description", "IGNRating", "ImageUrl", "Name", "Year" },
                values: new object[,]
                {
                    { 23, "BioWare", "Commander Shepard assembles a squad of specialists for a suicide mission against the Collectors. Choices from the first game carry over, and every squadmate's loyalty matters.", 9.6f, null, "Mass Effect 2", 2010 },
                    { 24, "2K Boston", "Explore Rapture, a crumbling underwater city built on extreme ideals. Combine plasmids and weapons in a shooter famous for its atmosphere and its twist.", 9.7f, null, "BioShock", 2007 },
                    { 25, "Valve", "Gordon Freeman returns to fight the alien Combine in City 17. A groundbreaking shooter known for its physics puzzles and the iconic gravity gun.", 9.7f, null, "Half-Life 2", 2004 },
                    { 26, "Nintendo EAD Tokyo", "Mario blasts off into space, running around tiny planets with their own gravity to rescue Princess Peach from Bowser.", 9.7f, null, "Super Mario Galaxy", 2007 },
                    { 27, "Capcom", "Agent Leon S. Kennedy heads to rural Spain to rescue the president's daughter from a mysterious cult. The over-the-shoulder camera changed action games forever.", 9.8f, null, "Resident Evil 4", 2005 },
                    { 28, "Kojima Productions", "Venom Snake builds a private army and takes on missions across Afghanistan and Africa, with total freedom in how you sneak, fight or improvise.", 10f, null, "Metal Gear Solid V: The Phantom Pain", 2015 },
                    { 29, "Naughty Dog", "Treasure hunter Nathan Drake races to find the lost city of Shambhala in a cinematic adventure full of set pieces, climbing and shootouts.", 9.5f, null, "Uncharted 2: Among Thieves", 2009 },
                    { 30, "Naughty Dog", "Smuggler Joel escorts 14-year-old Ellie across a ruined America twenty years after a fungal outbreak. A survival story driven by one of gaming's best relationships.", 10f, null, "The Last of Us", 2013 },
                    { 31, "FromSoftware", "Hunt nightmarish beasts through the gothic city of Yharnam. Faster and more aggressive than Dark Souls, rewarding players who fight back.", 9.1f, null, "Bloodborne", 2015 },
                    { 32, "Bandai Namco Studios", "Every fighter in Smash history returns in one massive crossover brawler. Great for parties and deep enough for competitive play.", 9.8f, null, "Super Smash Bros. Ultimate", 2018 },
                    { 33, "Nintendo EPD", "The definitive Mario Kart with dozens of tracks, anti-gravity racing and smart steering options so the whole family can play.", 9.2f, null, "Mario Kart 8 Deluxe", 2017 },
                    { 34, "Blizzard Entertainment", "Team-based hero shooter where every character has unique abilities. Coordinate with your team to push the payload or hold the point.", 9.4f, null, "Overwatch", 2016 },
                    { 35, "Bethesda Game Studios", "Emerge from Vault 111 into the post-apocalyptic Commonwealth to search for your missing son. Explore, craft and build settlements across the wasteland.", 9.5f, null, "Fallout 4", 2015 },
                    { 36, "Guerrilla Games", "Aloy hunts giant robotic creatures in a lush world where nature has reclaimed the remains of a lost civilization, and uncovers the truth behind it.", 9.3f, null, "Horizon Zero Dawn", 2017 },
                    { 37, "Kojima Productions", "Sam Porter Bridges reconnects a fractured America by delivering cargo across dangerous terrain. A strange, divisive game about connection.", 6.8f, null, "Death Stranding", 2019 },
                    { 38, "Rocksteady Studios", "Batman is trapped inside a walled-off district of Gotham run by his worst enemies. Fluid combat, gadgets and gliding across rooftops.", 9.5f, null, "Batman: Arkham City", 2011 },
                    { 39, "Hazelight Studios", "A couple on the verge of divorce is shrunk into dolls and must work together to get home. A creative co-op adventure that changes its gameplay every level.", 9f, null, "It Takes Two", 2021 },
                    { 40, "Respawn Entertainment", "Free-to-play battle royale with unique Legends, fast movement and a smart ping system that makes teamwork easy even without voice chat.", 9f, null, "Apex Legends", 2019 },
                    { 41, "Blizzard Entertainment", "Lilith returns to Sanctuary in a dark action RPG. Build your character, clear dungeons and chase better loot solo or with friends.", 9f, null, "Diablo IV", 2023 },
                    { 42, "Square Enix", "Cloud Strife and the rebel group Avalanche fight the Shinra corporation in a reimagined Midgar, with real-time action combat and a new take on the classic story.", 9f, null, "Final Fantasy VII Remake", 2020 }
                });

            migrationBuilder.InsertData(
                table: "GameCategories",
                columns: new[] { "GameCategoryId", "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 62, "RPG", 23 },
                    { 63, "F", 23 },
                    { 64, "S", 23 },
                    { 65, "S", 24 },
                    { 66, "F", 24 },
                    { 67, "A", 24 },
                    { 68, "S", 25 },
                    { 69, "F", 25 },
                    { 70, "A", 25 },
                    { 71, "D", 26 },
                    { 72, "CAS", 26 },
                    { 73, "A", 27 },
                    { 74, "S", 27 },
                    { 75, "A", 28 },
                    { 76, "O", 28 },
                    { 77, "STR", 28 },
                    { 78, "A", 29 },
                    { 79, "D", 29 },
                    { 80, "S", 29 },
                    { 81, "A", 30 },
                    { 82, "D", 30 },
                    { 83, "S", 30 },
                    { 84, "A", 31 },
                    { 85, "RPG", 31 },
                    { 86, "FAN", 31 },
                    { 87, "COMP", 32 },
                    { 88, "CAS", 32 },
                    { 89, "A", 32 },
                    { 90, "SPORT", 33 },
                    { 91, "CAS", 33 },
                    { 92, "COMP", 33 },
                    { 93, "S", 34 },
                    { 94, "COMP", 34 },
                    { 95, "F", 34 },
                    { 96, "RPG", 35 },
                    { 97, "O", 35 },
                    { 98, "F", 35 },
                    { 99, "A", 36 },
                    { 100, "O", 36 },
                    { 101, "F", 36 },
                    { 102, "D", 37 },
                    { 103, "O", 37 },
                    { 104, "F", 37 },
                    { 105, "A", 38 },
                    { 106, "D", 38 },
                    { 107, "O", 38 },
                    { 108, "D", 39 },
                    { 109, "C", 39 },
                    { 110, "CAS", 39 },
                    { 111, "S", 40 },
                    { 112, "COMP", 40 },
                    { 113, "RPG", 41 },
                    { 114, "A", 41 },
                    { 115, "FAN", 41 },
                    { 116, "RPG", 42 },
                    { 117, "A", 42 },
                    { 118, "F", 42 }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "GameId", "GameRating", "GameReview" },
                values: new object[,]
                {
                    { 61, 23, 10f, "The suicide mission is the best final act in any RPG. I was nervous about every squadmate." },
                    { 62, 23, 9.5f, "Great characters and loyalty missions. Planet scanning was a chore though." },
                    { 63, 23, 9f, "Still holds up in the Legendary Edition." },
                    { 64, 24, 10f, "Would you kindly play this game? The atmosphere of Rapture is unforgettable." },
                    { 65, 24, 9f, "Amazing story and setting. Combat is a bit clunky by today's standards." },
                    { 66, 25, 9.5f, "The gravity gun is still one of the most fun weapons in any game." },
                    { 67, 25, 9f, "Ravenholm scared me as a kid and still does." },
                    { 68, 25, 8.5f, "Some sections drag, but it was way ahead of its time." },
                    { 69, 26, 10f, "Pure creativity. Every galaxy feels like a new idea." },
                    { 70, 26, 9.5f, "The music is incredible and the gravity mechanics never get old." },
                    { 71, 27, 10f, "Perfect pacing from start to finish. The village fight at the start is legendary." },
                    { 72, 27, 9f, "Leon's one-liners are cheesy in the best way. Still fun decades later." },
                    { 73, 27, 8.5f, "Escort sections with Ashley can be annoying, but everything else is great." },
                    { 74, 28, 10f, "The freedom is unmatched. Every outpost can be tackled in a dozen ways." },
                    { 75, 28, 8f, "Incredible gameplay, but the story feels unfinished near the end." },
                    { 76, 28, 9f, "Fulton-ing sheep back to Mother Base never gets old." },
                    { 77, 29, 9.5f, "The train level is one of the best set pieces ever made." },
                    { 78, 29, 9f, "Great banter between the characters and gorgeous locations." },
                    { 79, 30, 10f, "The ending hit me harder than any movie. Masterpiece." },
                    { 80, 30, 9.5f, "Tense, beautiful and heartbreaking. Every encounter feels desperate." },
                    { 81, 30, 9f, "Play the remastered version if you can. Still amazing." },
                    { 82, 31, 10f, "The best world design FromSoftware has ever done. Yharnam is unforgettable." },
                    { 83, 31, 9f, "Fast and aggressive combat that rewards you for being bold." },
                    { 84, 31, 8f, "Load times on PS4 hurt, but the game itself is incredible." },
                    { 85, 32, 10f, "Everyone is here! Game nights with friends are chaos in the best way." },
                    { 86, 32, 9f, "Huge roster and tons of stages. World of Light mode was a nice bonus." },
                    { 87, 33, 9f, "Our family's favorite game. Smart steering lets my kids race with us." },
                    { 88, 33, 9.5f, "Tons of tracks with the booster pass. Blue shells still hurt." },
                    { 89, 33, 8.5f, "Great online races, though some tracks feel too similar." },
                    { 90, 34, 9f, "Every hero feels different and the art style is fantastic." },
                    { 91, 34, 8f, "So fun with a good team. Frustrating with a bad one." },
                    { 92, 34, 9.5f, "Played this nonstop for two years. Great memories." },
                    { 93, 35, 9f, "Building settlements took up way more of my time than I expected." },
                    { 94, 35, 8f, "Great exploration, but the dialogue system is a step back from earlier Fallouts." },
                    { 95, 36, 9.5f, "Fighting robot dinosaurs with a bow is exactly as cool as it sounds." },
                    { 96, 36, 9f, "Beautiful world and a surprisingly great sci-fi mystery." },
                    { 97, 37, 8f, "Weird, slow and somehow really relaxing. Nothing else is like it." },
                    { 98, 37, 5.5f, "Beautiful, but I couldn't get into walking packages across the map for hours." },
                    { 99, 37, 9f, "Finding a ladder someone else left for you is such a cool feeling." },
                    { 100, 38, 9.5f, "Gliding over Arkham City and taking down thugs never gets old." },
                    { 101, 38, 9f, "Great villains and a ton of Riddler challenges to find." },
                    { 102, 39, 10f, "Best co-op game I've ever played. Every level has a new idea." },
                    { 103, 39, 9f, "Played it with my partner and we loved it. The squirrel fight was hilarious." },
                    { 104, 39, 8.5f, "The story is a little cheesy, but the gameplay is brilliant." },
                    { 105, 40, 9f, "The movement and gunplay feel amazing, and the ping system is genius." },
                    { 106, 40, 7.5f, "Great game, but it can get sweaty fast in ranked." },
                    { 107, 41, 9f, "Dark tone, great campaign and satisfying loot." },
                    { 108, 41, 7.5f, "The campaign is great, but the endgame needed more when it launched." },
                    { 109, 41, 8.5f, "Seasons have improved it a lot. Fun with friends." },
                    { 110, 42, 9f, "Combat blends action and strategy perfectly. Midgar looks amazing." },
                    { 111, 42, 8.5f, "Some filler sections, but the characters shine." },
                    { 112, 42, 9.5f, "Hearing the classic music remade brought back so many memories." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "GameCategories",
                keyColumn: "GameCategoryId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Games");
        }
    }
}
