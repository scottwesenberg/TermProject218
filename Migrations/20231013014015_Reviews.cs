using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject1.Migrations
{
    public partial class Reviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameRating = table.Column<float>(type: "real", nullable: false),
                    GameReview = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "GameId", "GameRating", "GameReview" },
                values: new object[,]
                {
                    { 1, 1, 9.3f, "This game is absolutely breathtaking. The visual graphics and interactions will have you stomping around in the snow for hours. I highly reccomend this game to anyone who likes a semi-casual shooter with amazing graphics and a gret story." },
                    { 2, 2, 7.5f, "Starfield is a cool space experiece with quite a bit to offer. It has game physics that will keep you insterested, but I have a hard time wanting to follow to story. I'd rather just explore the vastness of space." },
                    { 3, 2, 9.3f, "BEST GAME EVER I LOVE SPACE" },
                    { 4, 3, 9f, "Elden Ring is a gorgeous open world game, with seamless graphics and fighting mechanics. It is a beautifully made game, though it is very difficult!" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_GameId",
                table: "Review",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
