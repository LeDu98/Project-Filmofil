using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class logoImg_data_for_streaingService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1,
                column: "LogoImg",
                value: "universal.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 2,
                column: "LogoImg",
                value: "Warner_Bros._(2019)_logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 3,
                column: "LogoImg",
                value: "1200px-Sony_Pictures_Television_logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 4,
                column: "LogoImg",
                value: "20th_Century_Studios_2020_logo.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 5,
                column: "LogoImg",
                value: "Walt_Disney_Pictures_2011_logo.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 6,
                column: "LogoImg",
                value: "Metro-Goldwyn-Mayer_logo.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1,
                column: "LogoImg",
                value: "img/studioLogo/universal.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 2,
                column: "LogoImg",
                value: "img/studioLogo/Warner_Bros._(2019)_logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 3,
                column: "LogoImg",
                value: "img/studioLogo/1200px-Sony_Pictures_Television_logo.svg.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 4,
                column: "LogoImg",
                value: "img/studioLogo/20th_Century_Studios_2020_logo.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 5,
                column: "LogoImg",
                value: "img/studioLogo/Walt_Disney_Pictures_2011_logo.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 6,
                column: "LogoImg",
                value: "img/studioLogo/Metro-Goldwyn-Mayer_logo.png");
        }
    }
}
