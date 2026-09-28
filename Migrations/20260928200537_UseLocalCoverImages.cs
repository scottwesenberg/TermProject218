using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllGamesGameReviews.Migrations
{
    /// <inheritdoc />
    public partial class UseLocalCoverImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/games/red-dead-redemption-2.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/games/starfield.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/games/elden-ring.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "/images/games/god-of-war.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/games/the-witcher-3-wild-hunt.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/games/the-elder-scrolls-v-skyrim.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/games/grand-theft-auto-v.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/games/the-last-of-us-part-ii.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/images/games/baldur-s-gate-3.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "/images/games/cyberpunk-2077.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "/images/games/halo-infinite.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "/images/games/hades.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "/images/games/ghost-of-tsushima.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "/images/games/marvel-s-spider-man.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "/images/games/sekiro-shadows-die-twice.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "/images/games/hollow-knight.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "/images/games/doom.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "/images/games/portal-2.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "/images/games/bioshock.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "/images/games/half-life-2.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "/images/games/resident-evil-4.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "/images/games/metal-gear-solid-v-the-phantom-pain.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "/images/games/the-last-of-us.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "/images/games/fallout-4.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "/images/games/horizon-zero-dawn.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "/images/games/death-stranding.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "/images/games/batman-arkham-city.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "/images/games/it-takes-two.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "/images/games/apex-legends.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "/images/games/diablo-iv.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "/images/games/final-fantasy-vii-remake.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1174180/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1716740/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1245620/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1593500/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/292030/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/489830/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/271590/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2531310/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1086940/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1091500/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1240440/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1145360/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2215430/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1817070/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/814380/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/367520/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/379720/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/620/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 24,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/409710/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 25,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/220/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 27,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/254700/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 28,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/287700/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 30,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1888930/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 35,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/377160/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 36,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1151640/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 37,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1190460/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 38,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/200260/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 39,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1426210/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 40,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1172470/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 41,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/2344520/header.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 42,
                column: "ImageUrl",
                value: "https://shared.akamai.steamstatic.com/store_item_assets/steam/apps/1462040/header.jpg");
        }
    }
}
