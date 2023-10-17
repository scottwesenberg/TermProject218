using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject1.Migrations
{
    public partial class Category2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameCategory_Categories_CategoryId",
                table: "GameCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_GameCategory_Games_GameId",
                table: "GameCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory");

            migrationBuilder.RenameTable(
                name: "GameCategory",
                newName: "GameCategories");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategory_GameId",
                table: "GameCategories",
                newName: "IX_GameCategories_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategory_CategoryId",
                table: "GameCategories",
                newName: "IX_GameCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories",
                column: "GameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Categories_CategoryId",
                table: "GameCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategories_Games_GameId",
                table: "GameCategories",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Categories_CategoryId",
                table: "GameCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_GameCategories_Games_GameId",
                table: "GameCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameCategories",
                table: "GameCategories");

            migrationBuilder.RenameTable(
                name: "GameCategories",
                newName: "GameCategory");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategories_GameId",
                table: "GameCategory",
                newName: "IX_GameCategory_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_GameCategories_CategoryId",
                table: "GameCategory",
                newName: "IX_GameCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameCategory",
                table: "GameCategory",
                column: "GameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategory_Categories_CategoryId",
                table: "GameCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameCategory_Games_GameId",
                table: "GameCategory",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
