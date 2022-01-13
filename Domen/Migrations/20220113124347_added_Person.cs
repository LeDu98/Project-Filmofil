using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class added_Person : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acting_Actors_ActorId",
                table: "Acting");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Country_CountryId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Country_CountryId",
                table: "Personnel");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Personnel_PersonnelId",
                table: "Positions");


            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel");

            migrationBuilder.DropIndex(
                name: "IX_Personnel_CountryId",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_CountryId",
                table: "Actors");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyColumnType: "int",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personnel",
                keyColumn: "PersonnelId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StreamingService",
                keyColumn: "StreamingServiceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Studio",
                keyColumn: "StudioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "PersonnelId",
                table: "Personnel");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Personnel");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "Born",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Personnel",
                newName: "Trademark");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Personnel",
                newName: "PersonId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Actors",
                newName: "PersonId");

            migrationBuilder.AddColumn<double>(
                name: "Networth",
                table: "Actors",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel",
                column: "PersonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "PersonId");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Born = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Persons_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acting_Actors_ActorId",
                table: "Acting",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Persons_PersonId",
                table: "Actors",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Persons_PersonId",
                table: "Personnel",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Personnel_PersonnelId",
                table: "Positions",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acting_Actors_ActorId",
                table: "Acting");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Persons_PersonId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnel_Persons_PersonId",
                table: "Personnel");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Personnel_PersonnelId",
                table: "Positions");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "Networth",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "Trademark",
                table: "Personnel",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Personnel",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Actors",
                newName: "CountryId");

            migrationBuilder.AddColumn<int>(
                name: "PersonnelId",
                table: "Personnel",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Personnel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "Born",
                table: "Actors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personnel",
                table: "Personnel",
                column: "PersonnelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                table: "Actors",
                column: "ActorId");

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorsActorId = table.Column<int>(type: "int", nullable: false),
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorsActorId, x.MoviesMovieId });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_ActorsActorId",
                        column: x => x.ActorsActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePersonnel",
                columns: table => new
                {
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false),
                    PersonnelsPersonnelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePersonnel", x => new { x.MoviesMovieId, x.PersonnelsPersonnelId });
                    table.ForeignKey(
                        name: "FK_MoviePersonnel_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePersonnel_Personnel_PersonnelsPersonnelId",
                        column: x => x.PersonnelsPersonnelId,
                        principalTable: "Personnel",
                        principalColumn: "PersonnelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    MoviesMovieId = table.Column<int>(type: "int", nullable: false),
                    UsersUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.MoviesMovieId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_MovieUser_Movies_MoviesMovieId",
                        column: x => x.MoviesMovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryId", "Name" },
                values: new object[] { 1, "United States" });

            migrationBuilder.InsertData(
                table: "StreamingService",
                columns: new[] { "StreamingServiceId", "Founded", "Headquarter", "LogoImg", "Name", "Price", "Website" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Gatos, California, United States", "img/streamingServiceLogo/netflix.png", "Netflix", 17.989999999999998, "https://netflix.com/" },
                    { 2, new DateTime(2006, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seattle, Washington, United States", "img/streamingServiceLogo/amazon-prime-video.png", "Amazon Prime Video", 12.99, "https://www.primevideo.com/" },
                    { 3, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "img/streamingServiceLogo/disney-plus.png", "Disney+", 7.9900000000000002, "https://www.disneyplus.com/" },
                    { 4, new DateTime(1972, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "img/streamingServiceLogo/hbo.png", "HBO", 9.9900000000000002, "https://www.hbo.com/" },
                    { 5, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York, New York, United States", "img/streamingServiceLogo/apple tv.png", "Apple TV+", 4.9900000000000002, "https://www.apple.com/apple-tv-plus/" }
                });

            migrationBuilder.InsertData(
                table: "Studio",
                columns: new[] { "StudioId", "Founded", "Headquarter", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1912, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Universal City, California, United States", "Universal Pictures" },
                    { 2, new DateTime(1923, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "Warner Bros. Pictures" },
                    { 3, new DateTime(1987, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Culver City, California, United States", "Sony Pictures" },
                    { 4, new DateTime(1935, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "20th Century Studios" },
                    { 5, new DateTime(1923, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burbank, California, United States", "Walt Disney Pictures" },
                    { 6, new DateTime(1924, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Los Angeles, California, United States", "Metro-Goldwyn-Mayer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "IsAdministrator", "LastName", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "admin@gmail.com", "Admin", true, "Admin", "admin", "admin" },
                    { 2, "milosv@gmail.com", "Milos", true, "Vujic", "12345", "milosv" },
                    { 3, "dusang@gmail.com", "Dusan", true, "Gajic", "12345", "dusang" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Born", "CountryId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Leonardo", "DiCaprio" },
                    { 2, new DateTime(1990, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jennifer", "Lawrence" },
                    { 3, new DateTime(1949, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Meryl", "Streep" },
                    { 4, new DateTime(1983, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jonah", "Hill" }
                });

            migrationBuilder.InsertData(
                table: "Personnel",
                columns: new[] { "PersonnelId", "CountryId", "FirstName", "LastName" },
                values: new object[] { 1, 1, "Adam", "McKay" });

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_CountryId",
                table: "Personnel",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Actors_CountryId",
                table: "Actors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MoviesMovieId",
                table: "ActorMovie",
                column: "MoviesMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePersonnel_PersonnelsPersonnelId",
                table: "MoviePersonnel",
                column: "PersonnelsPersonnelId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersUserId",
                table: "MovieUser",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acting_Actors_ActorId",
                table: "Acting",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Country_CountryId",
                table: "Actors",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnel_Country_CountryId",
                table: "Personnel",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Personnel_PersonnelId",
                table: "Positions",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
