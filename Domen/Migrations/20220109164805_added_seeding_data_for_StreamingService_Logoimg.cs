using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class added_seeding_data_for_StreamingService_Logoimg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 1,
                column: "LogoImg",
                value: "img/streamingServiceLogo/netflix.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 2,
                column: "LogoImg",
                value: "img/streamingServiceLogo/amazon-prime-video.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 3,
                column: "LogoImg",
                value: "img/streamingServiceLogo/disney-plus.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 4,
                column: "LogoImg",
                value: "img/streamingServiceLogo/hbo.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 5,
                column: "LogoImg",
                value: "img/streamingServiceLogo/apple tv.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 1,
                column: "LogoImg",
                value: null);

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 2,
                column: "LogoImg",
                value: null);

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 3,
                column: "LogoImg",
                value: null);

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 4,
                column: "LogoImg",
                value: null);

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 5,
                column: "LogoImg",
                value: null);
        }
    }
}
