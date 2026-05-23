using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class AddComingMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genre",
                value: "Komedi, Familj, Mysterium");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "AgeRating", "Description", "Director", "DurationMinutes", "Genre", "ImageUrl", "IsShowing", "OriginalLanguage", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[,]
                {
                    { 5, "Ai Mikami, Natsuki Hanae, Hiccorohee, Kana Hanazawa, Mô Chûgakusei", "Från 11 år: Får ses på bio av den som fyllt 7 år i sällskap med vuxen.", "Rita har hamnat i en tidsloop under en utomjordisk invasion, återupplever samma dag om och om igen och blir långsamt en alltmer effektiv krigare. Utmattad av en oändlig rad av dödsögonblick upptäcker hon Keiji, en annan person som hamnat i samma loop.", "Kenichiro Akimoto", 86, "Anime", "/images/allyouneediskill.jpg", false, "Japanska", "All You Need Is Kill", new DateOnly(2026, 5, 29), 129.0, "All You Need Is Kill" },
                    { 6, "Marlon Wayans, Shawn Wayans, Anna Faris, Regina Hall, Damon Wayans Jr., Gregg Wayans, Kim Wayans, Benny Zielke, Cameron Scott Roberts, Cheri Oteri, Chris Elliott, Dave Sheridan, Heidi Gardner, Lochlyn Munro", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "26 år efter att ha sprungit ifrån en misstänkt välbekant maskerad mördare (“Ghostface”), är original-fyran måltavla för mördaren igen och ingen skräckfilms-serie går säker. Marlon Wayans (“Shorty”), Shawn Wayans (“Ray”), Anna Faris (“Cindy”) och Regina Hall (“Brenda”) återförenas i Scary Movie, tillsammans med återvändande favoriter och nya ansikten, för att hugga sig igenom reboots, nyinspelningar, reboots på nyinspelningar, prequels, sequels, spin-offs, arthouse-horror, ursprungshistorier, allting som anses vara ikoniskt , och vartenda “sista kapitel” som verkligen inte är det sista.\n\nIngenting är heligt. Inget berättargrepp går säkert. Alla gränser korsas. Bröderna Wayans är tillbaka för att cancellera cancel-kulturen.", "Michael Tiddes", 95, "Skräck, Komedi", "/images/scarymovie.jpg", false, "Engelska", "Scary Movie", new DateOnly(2026, 6, 5), 159.0, "Scary Movie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Genre",
                value: "Familj");
        }
    }
}
