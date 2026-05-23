using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Models;

public class Movie
{
    public int Id { get; set; }
    [MaxLength(100)]
    public required string Title { get; set; }
    [MaxLength(100)]
    public required string Director { get; set; }
    [MaxLength(200)]
    public required string Actors { get; set; }
    [MaxLength(500)]
    public required string OriginalTitle { get; set; }
    [MaxLength(200)]
    public required string OriginalLanguage { get; set; }
    [MaxLength(50)]
    public required string Genre { get; set; }
    [MaxLength(750)]
    public string Description { get; set; } = string.Empty;
    [MaxLength(200)]
    public required string AgeRating { get; set; }
    public int DurationMinutes { get; set; }
    public DateOnly Premiere { get; set; }
    public double Price { get; set; }
    // IsShowing gör att filmen visas under antingen "Nu på bio" eller "Kommer snart" i frontend.
    public bool IsShowing { get; set; } = true;
    [MaxLength(500)]
    public string ImageUrl { get; set; } = string.Empty;
}
