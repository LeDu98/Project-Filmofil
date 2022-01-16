using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domen.Migrations
{
    public partial class added_seeders_for_movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Duration", "Genres", "Name", "Rating", "StreamingServiceId", "StudioId", "Synopsis", "Thumbnail", "Trailer", "Year" },
                values: new object[,]
                {
                    { 1, 142, "Drama", "The Shawshank Redemption", 9.3000000000000007, 1, 1, "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red", "shawshank.png", "https://www.youtube.com/watch?v=6hB3S9bIaco", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994) },
                    { 2, 175, "Crime, Drama", "The Godfather", 9.0999999999999996, 2, 2, "The Godfather Don Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.", "godfather.jpg", "https://www.youtube.com/watch?v=sY1S34973zA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972) },
                    { 3, 152, "Action, Crime, Drama, Thriller", "The Dark Knight", 9.0, 3, 3, "Set within a year after the events of Batman Begins (2005), Batman, Lieutenant James Gordon, and new District Attorney Harvey Dent successfully begin to round up the criminals that plague Gotham City, until a mysterious and sadistic criminal mastermind known only as The Joker appears in Gotham, creating a new wave of chaos. Batman's struggle against The Joker becomes deeply personal, forcing him to confront everything he believes and improve his technology to stop him. A love triangle develops between Bruce Wayne, Dent, and Rachel Dawes.", "darkKnight.png", "https://www.youtube.com/watch?v=EXeTwQWrcwY", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008) },
                    { 4, 201, "Action, Adventure, Drama, Fantasy", "The Lord of the Rings: The Return of the King", 8.9000000000000004, 4, 4, "The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Frodo and Sam reach Mordor in their quest to destroy the One Ring, while Aragorn leads the forces of good against Sauron's evil army at the stone city of Minas Tirith.", "LOTR-3-The-Return-of-the-King-icon.png", "https://www.youtube.com/watch?v=r5X-hFf6Bwo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2003) }
                });

            migrationBuilder.InsertData(
                table: "Acting",
                columns: new[] { "ActorId", "MovieId", "Income", "Role" },
                values: new object[,]
                {
                    { 1, 1, 7.5, "Police officer" },
                    { 2, 1, 2.5, "Laywer" },
                    { 3, 1, 4.0, "Judge" },
                    { 4, 2, 10.5, "Don" },
                    { 2, 2, 1.5, "Laywer" },
                    { 7, 2, 0.75, "Dautgher" },
                    { 8, 3, 12.5, "Batman" },
                    { 6, 3, 2.5, "Jane Hawkins" },
                    { 7, 3, 4.0, "Adam" },
                    { 1, 4, 7.2000000000000002, "Legolas" },
                    { 3, 4, 5.5, "Witch" },
                    { 4, 4, 5.0, "Gremlin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Acting",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);
        }
    }
}
