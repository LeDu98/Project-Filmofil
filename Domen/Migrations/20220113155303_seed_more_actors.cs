using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seed_more_actors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 2, "United Kingdom" });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 3, "France" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[] { 6, new DateTime(2001, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Freya", "img/ActorsImages/freyaAllan.jpg", "Allan" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[] { 8, new DateTime(1989, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Daniel", "img/ActorsImages/danielRadcliffe.jfif", "Radcliffe" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Born", "CountryId", "FirstName", "Image", "LastName" },
                values: new object[] { 7, new DateTime(1990, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Emma", "img/ActorsImages/emmaWatson.jpg", "Watson" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Networth" },
                values: new object[] { 6, 500000.0 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Networth" },
                values: new object[] { 8, 110000000.0 });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "PersonId", "Networth" },
                values: new object[] { 7, 85000000.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 3);
        }
    }
}
