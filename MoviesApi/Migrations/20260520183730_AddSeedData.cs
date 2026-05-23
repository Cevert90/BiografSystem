using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MoviesApi.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "AgeRating", "Director", "DurationMinutes", "Genre", "IsShowing", "OriginalLanguage", "OriginalTitle", "Premiere", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Jack Reynor, Laia Costa, Hayat Kamille", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "Lee Cronin", 134, "Skräck", true, "Engelska", "Lee Cronin's The Mummy", new DateOnly(2026, 4, 17), 169.0, "The Mummy" },
                    { 2, "Michael Johnston, Inde Navarrette", "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.", "Curry Barker", 108, "Skräck", true, "Engelska", "Obsession", new DateOnly(2026, 5, 15), 189.0, "Obsession" },
                    { 3, "Okänd", "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap.", "Okänd", 85, "Familj", true, "Svenska", "Fårdetektiverna", new DateOnly(2026, 5, 1), 119.0, "Fårdetektiverna" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
