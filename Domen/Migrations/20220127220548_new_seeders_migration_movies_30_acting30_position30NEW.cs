using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class new_seeders_migration_movies_30_acting30_position30NEW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 69,
                column: "Image",
                value: "3000 (1).jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 69,
                column: "Image",
                value: "image-w856 (2).jpg");
        }
    }
}
