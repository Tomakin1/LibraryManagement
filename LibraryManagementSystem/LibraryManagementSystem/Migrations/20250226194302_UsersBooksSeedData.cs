using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UsersBooksSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usersBooks_Books_BooksId",
                table: "usersBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_usersBooks_Users_UsersId",
                table: "usersBooks");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "usersBooks",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "usersBooks",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_usersBooks_UsersId",
                table: "usersBooks",
                newName: "IX_usersBooks_UserId");

            migrationBuilder.InsertData(
                table: "usersBooks",
                columns: new[] { "BookId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_usersBooks_Books_BookId",
                table: "usersBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usersBooks_Users_UserId",
                table: "usersBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usersBooks_Books_BookId",
                table: "usersBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_usersBooks_Users_UserId",
                table: "usersBooks");

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "usersBooks",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "usersBooks",
                newName: "BooksId");

            migrationBuilder.RenameIndex(
                name: "IX_usersBooks_UserId",
                table: "usersBooks",
                newName: "IX_usersBooks_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_usersBooks_Books_BooksId",
                table: "usersBooks",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_usersBooks_Users_UsersId",
                table: "usersBooks",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
