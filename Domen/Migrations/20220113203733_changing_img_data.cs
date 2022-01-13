using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class changing_img_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                column: "Image",
                value: "diCaprio.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                column: "Image",
                value: "jennifer-lawrence_gettyimages-626382596jpg.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                column: "Image",
                value: "merylStreep.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 4,
                column: "Image",
                value: "jonahHill.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Image",
                value: "freyaAllan.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Image",
                value: "emmaWatson.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Image",
                value: "danielRadcliffe.jfif");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 1,
                column: "LogoImg",
                value: "netflix.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 2,
                column: "LogoImg",
                value: "amazon-prime-video.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 3,
                column: "LogoImg",
                value: "disney-plus.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 4,
                column: "LogoImg",
                value: "hbo.png");

            migrationBuilder.UpdateData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 5,
                column: "LogoImg",
                value: "apple tv.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 6,
                column: "Image",
                value: "img/ActorsImages/freyaAllan.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 7,
                column: "Image",
                value: "img/ActorsImages/emmaWatson.jpg");

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 8,
                column: "Image",
                value: "img/ActorsImages/danielRadcliffe.jfif");

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
    }
}
