using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class added_logoImg_studio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogoImg",
                table: "Studio",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoImg",
                table: "Studio");
        }
    }
}
