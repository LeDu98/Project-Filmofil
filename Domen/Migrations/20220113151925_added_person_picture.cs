using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class added_person_picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1,
                column: "LogoImg",
                value: "img/studioLogo/universal.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Persons");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1,
                column: "LogoImg",
                value: "img/studioLogo/Universal_Pictures_logo_2.png");
        }
    }
}
