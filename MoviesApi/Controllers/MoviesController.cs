using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;
using MoviesApi.Models;

namespace MoviesApi.Controllers;

[ApiController] // Aktiverar automatisk validering och felhantering.
[Route("api/[controller]")] // Sätter bas-URL till api/movies.
public class MoviesController : ControllerBase
{
    private readonly AppDbContext _db;

    // Tar emot databasen via dependency injection.
    public MoviesController(AppDbContext db)
    {
        _db = db;
    }

    // Hämtar alla filmer.
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var movies = await _db.Movies.ToListAsync();
        return Ok(movies);
    }

    // Hämtar en film baserat på filmens ID.
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var movie = await _db.Movies.FindAsync(id);
        if (movie == null)
            return NotFound();
        return Ok(movie);
    }

    // Lägger till en film.
    [HttpPost]
    public async Task<IActionResult> Create(Movie movie)
    {
        _db.Movies.Add(movie);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
    }

    // Uppdaterar en film med hjälp av filmens ID.
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Movie movie)
    {
        if (id != movie.Id)
            return BadRequest();

        var exists = await _db.Movies.AnyAsync(a => a.Id == id);
        if (!exists)
            return NotFound();

        _db.Entry(movie).State = EntityState.Modified;
        await _db.SaveChangesAsync();
        return NoContent();
    }

    // Tar bort en film med hjälp av filmens ID.
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var movie = await _db.Movies.FindAsync(id);
        if (movie == null)
            return NotFound();

        _db.Movies.Remove(movie);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}