using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class MoreDataSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 2, "Orhan", "Pamuk" },
                    { 3, "Elif", "Şafak" },
                    { 4, "Ahmet", "Ümit" },
                    { 5, "İlber", "Ortaylı" },
                    { 6, "Sabahattin", "Ali" },
                    { 7, "Yaşar", "Kemal" },
                    { 8, "Zülfü", "Livaneli" },
                    { 9, "Halide Edib", "Adıvar" },
                    { 10, "Reşat Nuri", "Güntekin" },
                    { 11, "Hakan", "Günday" },
                    { 12, "Ayşe", "Kulin" },
                    { 13, "Cengiz", "Aytmatov" },
                    { 14, "Dostoyevski", "Fyodor" },
                    { 15, "Stefan", "Zweig" }
                });

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Çekmeköy/İstanbul");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 2, "Ayşe", "Yılmaz" },
                    { 3, "Mehmet", "Kaya" },
                    { 4, "Elif", "Demir" },
                    { 5, "Hasan", "Çelik" },
                    { 6, "Zeynep", "Koç" },
                    { 7, "Ali", "Şahin" },
                    { 8, "Fatma", "Öztürk" },
                    { 9, "Emre", "Arslan" },
                    { 10, "Selin", "Yıldırım" },
                    { 11, "Burak", "Eren" },
                    { 12, "Gizem", "Aksoy" },
                    { 13, "Yusuf", "Taş" },
                    { 14, "Buse", "Kurt" },
                    { 15, "Deniz", "Aslan" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 2, "Tarih", "Beyaz Kale", 150 },
                    { 3, 3, "Roman", "Aşk", 130 },
                    { 4, 4, "Polisiye", "İstanbul Hatırası", 140 },
                    { 5, 5, "Tarih", "Kırk Ambar", 160 },
                    { 6, 6, "Roman", "Kürk Mantolu Madonna", 110 },
                    { 7, 7, "Macera", "İnce Memed", 170 },
                    { 8, 8, "Dram", "Serenad", 125 },
                    { 9, 9, "Tarih", "Ateşten Gömlek", 135 },
                    { 10, 10, "Roman", "Çalıkuşu", 145 },
                    { 11, 11, "Psikoloji", "Az", 155 },
                    { 12, 12, "Biyografi", "Füreya", 165 },
                    { 13, 13, "Roman", "Gün Olur Asra Bedel", 175 },
                    { 14, 14, "Klasik", "Suç ve Ceza", 180 },
                    { 15, 15, "Klasik", "Satranç", 190 }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "Id", "Address", "Age", "CategoryChoice", "UserId" },
                values: new object[,]
                {
                    { 2, "Kadıköy/İstanbul", 25, "Bilim Kurgu", 2 },
                    { 3, "Beşiktaş/İstanbul", 22, "Polisiye", 3 },
                    { 4, "Bornova/İzmir", 28, "Tarih", 4 },
                    { 5, "Osmangazi/Bursa", 30, "Macera", 5 },
                    { 6, "Konak/İzmir", 27, "Korku", 6 },
                    { 7, "Keçiören/Ankara", 21, "Biyografi", 7 },
                    { 8, "Şahinbey/Gaziantep", 29, "Felsefe", 8 },
                    { 9, "Odunpazarı/Eskişehir", 24, "Psikoloji", 9 },
                    { 10, "Melikgazi/Kayseri", 32, "Klasik", 10 },
                    { 11, "Eyyübiye/Şanlıurfa", 23, "Şiir", 11 },
                    { 12, "Mamak/Ankara", 26, "Edebiyat", 12 },
                    { 13, "Büyükçekmece/İstanbul", 31, "Tarih", 13 },
                    { 14, "Seyhan/Adana", 22, "Bilim", 14 },
                    { 15, "Ortahisar/Trabzon", 28, "Fantastik", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "qweqweqwdqwq");
        }
    }
}
