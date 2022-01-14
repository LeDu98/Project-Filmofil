using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seed_changed_networth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Networth",
                value: 260.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Networth",
                value: 160.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Networth",
                value: 160.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Networth",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Networth",
                value: 0.5);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Networth",
                value: 85.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Networth",
                value: 110.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Networth",
                value: 260000000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Networth",
                value: 160000000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Networth",
                value: 160000000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Networth",
                value: 50000000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Networth",
                value: 500000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Networth",
                value: 85000000.0);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Networth",
                value: 110000000.0);
        }
    }
}
