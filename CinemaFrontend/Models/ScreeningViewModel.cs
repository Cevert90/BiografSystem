namespace CinemaFrontend.Models;

public class ScreeningViewModel
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string MovieTitle { get; set; } = string.Empty;
    public DateTime ShowTime { get; set; }
    public string ScreeningRoom { get; set; } = string.Empty;
    public int AvailableSeats { get; set; }
    public string AgeRating { get; set; } = string.Empty;
    public double Price { get; set; }
}