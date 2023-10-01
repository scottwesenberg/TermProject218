using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject1.Migrations
{
    public partial class ItitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    IGNRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Creator", "IGNRating", "Name", "Year" },
                values: new object[] { 1, "Rockstar Studios", 10, "Red Dead Redemption 2", 2018 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Creator", "IGNRating", "Name", "Year" },
                values: new object[] { 2, "Bethesda Game Studios", 7, "Starfield", 2023 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Creator", "IGNRating", "Name", "Year" },
                values: new object[] { 3, "FromSoftware", 10, "Elden Ring", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
