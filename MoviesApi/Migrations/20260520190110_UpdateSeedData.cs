using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Hugh Jackman, Emma Thompson, Bella Ramsey", "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap.", "Kyle Balda", 109, "Familj", "The Sheep Detectives", new DateOnly(2026, 5, 8), 119.0, "Fårdetektiverna" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Actors", "Director", "DurationMinutes", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Jack Reynor, Laia Costa, Hayat Kamille", "Lee Cronin", 134, "Lee Cronin's The Mummy", new DateOnly(2026, 4, 17), 169.0, "The Mummy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "OriginalLanguage", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Karl Urban, Hiroyuki Sanada, Martyn Ford, Lewis Tan, Damon Herriman, Tati Gabrielle, Adeline Rudolph, Tadanobu Asano, Josh Lawson, Jessica McNamee, Mehcad Brooks, Ludi Lin, Joe Taslim, Chin Han, Ana Thu Nguyen, Desmond Chiam, Julian Weeks, Max Huang, CJ. Bloomfield", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "Simon McQuoid", 115, "Action", "Engelska", "Mortal Kombat II", new DateOnly(2026, 5, 8), 159.0, "Mortal Kombat II" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "IsShowing", "OriginalLanguage", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { 4, "Michael Johnston, Inde Navarrette, Andy Richter, Cooper Tomlinson, Megan Lawless, Haley Fitzgerald, Darin Toonder, Chloe Breen, Anthony Pavone", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "Curry Barker", 108, "Skräck", true, "Engelska", "Obsession", new DateOnly(2026, 5, 15), 189.0, "Obsession" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Jack Reynor, Laia Costa, Hayat Kamille", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "Lee Cronin", 134, "Skräck", "Lee Cronin's The Mummy", new DateOnly(2026, 4, 17), 169.0, "The Mummy" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Actors", "Director", "DurationMinutes", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Michael Johnston, Inde Navarrette", "Curry Barker", 108, "Obsession", new DateOnly(2026, 5, 15), 189.0, "Obsession" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "OriginalLanguage", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[] { "Okänd", "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap.", "Okänd", 85, "Familj", "Svenska", "Fårdetektiverna", new DateOnly(2026, 5, 1), 119.0, "Fårdetektiverna" });
        }
    }
}
