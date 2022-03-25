using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Data.Migrations
{
    public partial class FavoriteBooksTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBook_Books_BookId",
                table: "FavoriteBook");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBook_Users_UserId",
                table: "FavoriteBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteBook",
                table: "FavoriteBook");

            migrationBuilder.RenameTable(
                name: "FavoriteBook",
                newName: "FavoriteBooks");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteBook_BookId",
                table: "FavoriteBooks",
                newName: "IX_FavoriteBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteBooks",
                table: "FavoriteBooks",
                columns: new[] { "UserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Books_BookId",
                table: "FavoriteBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBooks_Users_UserId",
                table: "FavoriteBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Books_BookId",
                table: "FavoriteBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBooks_Users_UserId",
                table: "FavoriteBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FavoriteBooks",
                table: "FavoriteBooks");

            migrationBuilder.RenameTable(
                name: "FavoriteBooks",
                newName: "FavoriteBook");

            migrationBuilder.RenameIndex(
                name: "IX_FavoriteBooks_BookId",
                table: "FavoriteBook",
                newName: "IX_FavoriteBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FavoriteBook",
                table: "FavoriteBook",
                columns: new[] { "UserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBook_Books_BookId",
                table: "FavoriteBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBook_Users_UserId",
                table: "FavoriteBook",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
