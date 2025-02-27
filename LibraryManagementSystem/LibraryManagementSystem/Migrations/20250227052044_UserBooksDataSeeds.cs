using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UserBooksDataSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "usersBooks",
                columns: new[] { "BookId", "UserId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 15, 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "usersBooks",
                keyColumns: new[] { "BookId", "UserId" },
                keyValues: new object[] { 15, 15 });
        }
    }
}
