using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seeding_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
 
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "United States" });

            migrationBuilder.InsertData(
                table: "StreamingService",
                columns: new[] { "StreamingServiceId", "Founded", "Headquarter", "Name", "Price", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Gatos, California, United States", "Netflix", 17.989999999999998, "https://netflix.com/" },
                    { 2, new DateTime(2006, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle, Washington, United States", "Amazon Prime Video", 12.99, "https://www.primevideo.com/" },
                    { 3, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "Disney+", 7.9900000000000002, "https://www.disneyplus.com/" },
                    { 4, new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "HBO", 9.9900000000000002, "https://www.hbo.com/" },
                    { 5, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "Apple TV+", 4.9900000000000002, "https://www.apple.com/apple-tv-plus/" }
                });

            migrationBuilder.InsertData(
                table: "Studio",
                columns: new[] { "StudioId", "Founded", "Headquarter", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1912, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Universal City, California, United States", "Universal Pictures" },
                    { 2, new DateTime(1923, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "Warner Bros. Pictures" },
                    { 3, new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culver City, California, United States", "Sony Pictures" },
                    { 4, new DateTime(1935, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "20th Century Studios" },
                    { 5, new DateTime(1923, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "Walt Disney Pictures" },
                    { 6, new DateTime(1924, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "Metro-Goldwyn-Mayer" }
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
                table: "Actors",
                columns: new[] { "ActorId", "Born", "CountryId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Leonardo", "DiCaprio" },
                    { 2, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jennifer", "Lawrence" },
                    { 3, new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Meryl", "Streep" },
                    { 4, new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jonah", "Hill" }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonnelId", "CountryId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "Adam", "McKay" });
 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonnelId",
                keyValue: 1);

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
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);
        }
    }
}
