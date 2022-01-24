using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class seedersForPersonnels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 7,
                column: "LogoImg",
                value: "paramount_logo_icon512.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 7,
                column: "LogoImg",
                value: "Metro-Goldwyn-Mayer_logo.png");
        }
    }
}
