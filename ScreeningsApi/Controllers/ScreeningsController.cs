using Microsoft.AspNetCore.Mvc;
using ScreeningsApi.Models;

namespace ScreeningsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScreeningsController : ControllerBase
{
    private static readonly List<Screening> _screenings = new()
    {
        new Screening
        {
            Id = 1, 
            MovieId = 1, 
            MovieTitle = "Fårdetektiverna", 
            ShowTime = new DateTime(2026, 5, 22, 12, 0, 0), 
            ScreeningRoom = "Salong 1", 
            AvailableSeats = 44, 
            Price = 119, //Sänker priser vid matinévisning.
            AgeRating = "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap."
        },
        new Screening //Lägger till samma film med annat ID för att kunna visa filmen en annan tid.
        {
            Id = 2, 
            MovieId = 1, 
            MovieTitle = "Fårdetektiverna", 
            ShowTime = new DateTime(2026, 5, 22, 18, 0, 0), 
            ScreeningRoom = "Salong 1", 
            AvailableSeats = 44, 
            Price = 149, //Höjer priser för kvällsvisning.
            AgeRating = "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap."
        },
        new Screening 
        { 
            Id = 3, 
            MovieId = 2, 
            MovieTitle = "The Mummy", 
            ShowTime = new DateTime(2026, 5, 22, 18, 0, 0), 
            ScreeningRoom = "Salong 2 Plus", 
            AvailableSeats = 46, 
            Price = 169, 
            AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen."
        },
        new Screening 
        { 
            Id = 4, 
            MovieId = 2, 
            MovieTitle = "The Mummy", 
            ShowTime = new DateTime(2026, 5, 22, 21, 0, 0),
            ScreeningRoom = "Salong 2 Plus", 
            AvailableSeats = 46, 
            Price = 169,
            AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen."
        },
        new Screening
        {
            Id = 5, 
            MovieId = 3, 
            MovieTitle = "Mortal Kombat II", 
            ShowTime = new DateTime(2026, 5, 22, 21, 0, 0), 
            ScreeningRoom = "Salong 2", 
            AvailableSeats = 44, 
            Price = 159,
            AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen."
        },
        new Screening
        {
            Id = 6, 
            MovieId = 4, 
            MovieTitle = "Obsession", 
            ShowTime = new DateTime(2026, 5, 22, 21, 0, 0),  
            ScreeningRoom = "Salong 5 VIP", 
            AvailableSeats = 16, 
            Price = 189,
            AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen."
        },
    };

    // Hämtar alla visningar.
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_screenings);
    }

    // Hämtar alla visningar för en specifik film baserat biovisningens ID.
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var screening = _screenings.FirstOrDefault(s => s.Id == id);
        if (screening == null)
            return NotFound();
        return Ok(screening);
    }

    // Hämtar alla visningar för en specifik film baserat på filmens ID.
    [HttpGet("movie/{movieId}")]
    public IActionResult GetByMovie(int movieId)
    {
        var screenings = _screenings.Where(s => s.MovieId == movieId).ToList();
        return Ok(screenings);
    }
}