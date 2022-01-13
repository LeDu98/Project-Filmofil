using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seeding_new_data_with_changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "United States" });

            migrationBuilder.InsertData(
                table: "StreamingService",
                columns: new[] { "StreamingServiceId", "Founded", "Headquarter", "LogoImg", "Name", "Price", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Gatos, California, United States", "img/streamingServiceLogo/netflix.png", "Netflix", 17.989999999999998, "https://netflix.com/" },
                    { 2, new DateTime(2006, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle, Washington, United States", "img/streamingServiceLogo/amazon-prime-video.png", "Amazon Prime Video", 12.99, "https://www.primevideo.com/" },
                    { 3, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "img/streamingServiceLogo/disney-plus.png", "Disney+", 7.9900000000000002, "https://www.disneyplus.com/" },
                    { 4, new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "img/streamingServiceLogo/hbo.png", "HBO", 9.9900000000000002, "https://www.hbo.com/" },
                    { 5, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "img/streamingServiceLogo/apple tv.png", "Apple TV+", 4.9900000000000002, "https://www.apple.com/apple-tv-plus/" }
                });

            migrationBuilder.InsertData(
                table: "Studio",
                columns: new[] { "StudioId", "Founded", "Headquarter", "LogoImg", "Name", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(1912, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Universal City, California, United States", "img/studioLogo/Universal_Pictures_logo_2.png", "Universal Pictures", "https://www.universalpictures.com/" },
                    { 2, new DateTime(1923, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "img/studioLogo/Warner_Bros._(2019)_logo.svg.png", "Warner Bros. Pictures", "https://www.warnerbros.com/" },
                    { 3, new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culver City, California, United States", "img/studioLogo/1200px-Sony_Pictures_Television_logo.svg.png", "Sony Pictures", "https://www.sonypictures.com/" },
                    { 4, new DateTime(1935, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "img/studioLogo/20th_Century_Studios_2020_logo.jpg", "20th Century Studios", "https://www.20thcenturystudios.com/" },
                    { 5, new DateTime(1923, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "img/studioLogo/Walt_Disney_Pictures_2011_logo.png", "Walt Disney Pictures", "https://www.waltdisneystudios.com/" },
                    { 6, new DateTime(1924, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "img/studioLogo/Metro-Goldwyn-Mayer_logo.png", "Metro-Goldwyn-Mayer", "https://www.mgm.com/" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "IsAdministrator", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "admin@gmail.com", "Admin", true, "Admin", "admin", "admin" },
                    { 2, "milosv@gmail.com", "Milos", true, "Vujic", "12345", "milosv" },
                    { 3, "dusang@gmail.com", "Dusan", true, "Gajic", "12345", "dusang" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Leonardo", "DiCaprio" },
                    { 2, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jennifer", "Lawrence" },
                    { 3, new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Meryl", "Streep" },
                    { 4, new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jonah", "Hill" },
                    { 5, new DateTime(1968, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Adam", "McKay" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Networth" },
                values: new object[,]
                {
                    { 1, 260000000.0 },
                    { 2, 160000000.0 },
                    { 3, 160000000.0 },
                    { 4, 50000000.0 }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonId", "Trademark" },
                values: new object[] { 5, "Often begins his movies with a quote. Frequently works with Christian Bale, Steve Carell and Will Ferrell. Fast editing style." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
