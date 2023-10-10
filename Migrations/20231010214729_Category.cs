using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject1.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Games",
                newName: "Id");

            migrationBuilder.AlterColumn<float>(
                name: "IGNRating",
                table: "Games",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Games",
                type: "nvarchar(3000)",
                maxLength: 3000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categories_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    GameCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.GameCategoryId);
                    table.ForeignKey(
                        name: "FK_GameCategory_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GameCategory_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "GameId", "Name" },
                values: new object[,]
                {
                    { "A", null, null, "Action" },
                    { "C", null, null, "Comedy" },
                    { "CAS", null, null, "Casual" },
                    { "COMP", null, null, "Competitive" },
                    { "D", null, null, "Adventure" },
                    { "F", null, null, "Sci-Fi" },
                    { "FAN", null, null, "Fantasy" },
                    { "O", null, null, "Open-World" },
                    { "RPG", null, null, "Role-Playing" },
                    { "S", null, null, "Shooter" },
                    { "SPORT", null, null, "Sports" },
                    { "STR", null, null, "Strategy" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "IGNRating" },
                values: new object[] { "Red Dead Redemption 2 is an epic tale of life in America’s unforgiving heartland. The game's vast and atmospheric world also provides the foundation for a brand new online multiplayer experience.", 10f });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "IGNRating" },
                values: new object[] { "Elden Ring is an expansive fantasy Action-RPG game developed by FromSoftware, Inc. under the direction of Hidetaka Miyazaki and created in collaboration with famed author George R.R. Martin.", 7f });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "IGNRating" },
                values: new object[] { "Starfield is a next-generation roleplaying game set in space, created by the acclaimed team behind The Elder Scrolls and Fallout.", 10f });

            migrationBuilder.InsertData(
                table: "GameCategory",
                columns: new[] { "GameCategoryId", "CategoryId", "GameId" },
                values: new object[,]
                {
                    { 1, "O", 1 },
                    { 2, "S", 1 },
                    { 3, "A", 1 },
                    { 4, "F", 2 },
                    { 5, "O", 2 },
                    { 6, "RPG", 3 },
                    { 7, "F", 3 },
                    { 8, "FAN", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_GameId",
                table: "Categories",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCategory_CategoryId",
                table: "GameCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GameCategory_GameId",
                table: "GameCategory",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Games",
                newName: "GameId");

            migrationBuilder.AlterColumn<int>(
                name: "IGNRating",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "IGNRating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "IGNRating",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "IGNRating",
                value: 10);
        }
    }
}
