using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seed_actors_images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Image",
                value: "img/ActorsImages/diCaprio.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Image",
                value: "img/ActorsImages/jennifer-lawrence_gettyimages-626382596jpg.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Image",
                value: "img/ActorsImages/merylStreep.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Image",
                value: "img/ActorsImages/jonahHill.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Image",
                value: null);

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Image",
                value: null);
        }
    }
}
