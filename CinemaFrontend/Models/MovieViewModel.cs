namespace CinemaFrontend.Models;

public class MovieViewModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Actors { get; set; } = string.Empty;
    public string OriginalTitle { get; set; } = string.Empty;
    public string OriginalLanguage { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string AgeRating { get; set; } = string.Empty;
    public int DurationMinutes { get; set; }
    public DateOnly Premiere { get; set; }
    public double Price { get; set; }
    public bool IsShowing { get; set; }
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}