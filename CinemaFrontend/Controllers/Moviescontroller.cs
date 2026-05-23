using CinemaFrontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace CinemaFrontend.Controllers;


public class MoviesController : Controller
{
    private readonly HttpClient _httpClient;

    // Hämtar MoviesApi-klienten via dependency injection.
    public MoviesController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("MoviesApi");
    }

    // Visar alla filmer.
    public async Task<IActionResult> Index()
    {
        var movies = await _httpClient.GetFromJsonAsync<List<MovieViewModel>>("api/movies");
        return View(movies);
    }

    // Visar detaljerad information om en film.
    public async Task<IActionResult> Details(int id)
    {
        var movie = await _httpClient.GetFromJsonAsync<MovieViewModel>($"api/movies/{id}");
        if (movie == null)
            return NotFound();
        return View(movie);
    }
    
    // Visar formulär för att lägga till en film.
    [Authorize]  // Kollar ifall användaren är inloggad och den får i så fall tillgång till CRUD-metoderna.
    public IActionResult Create()
    {
        return View();
    }

    // Lägger till en film via formulär.
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(MovieViewModel model)
    {
        await _httpClient.PostAsJsonAsync("api/movies", model);
        return RedirectToAction(nameof(Index)); // nameof returnerar metodnamnet som en sträng ifall namnet skulle ändras.
    }

    // Visar formulär för att redigera en film.
    [Authorize]
    public async Task<IActionResult> Edit(int id)
    {
        var movie = await _httpClient.GetFromJsonAsync<MovieViewModel>($"api/movies/{id}");
        return View(movie);
    }

    // Uppdaterar en film via formulär.
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Edit(int id, MovieViewModel model)
    {
        await _httpClient.PutAsJsonAsync($"api/movies/{id}", model);
        return RedirectToAction(nameof(Index));
    }

    // Visar bekräftelsesida för att ta bort en film.
    [Authorize]
    public async Task<IActionResult> Delete(int id)
    {
        var movie = await _httpClient.GetFromJsonAsync<MovieViewModel>($"api/movies/{id}");
        return View(movie);
    }

    // Tar bort en film.
    [HttpPost, ActionName("Delete")]
    [Authorize]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _httpClient.DeleteAsync($"api/movies/{id}");
        return RedirectToAction(nameof(Index));
    }
}