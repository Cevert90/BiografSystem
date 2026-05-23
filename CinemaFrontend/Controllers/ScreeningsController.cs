using CinemaFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace CinemaFrontend.Controllers;

public class ScreeningsController : Controller
{
    private readonly HttpClient _httpClient;

    // Hämtar ScreeningsApi-klienten via dependency injection.
    public ScreeningsController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("ScreeningsApi");
    }

    // Visar alla visningar.
    public async Task<IActionResult> Index()
    {
        var screenings = await _httpClient.GetFromJsonAsync<List<ScreeningViewModel>>("api/screenings");
        return View(screenings);
    }

    // Visar alla visningar för en specifik film.
    public async Task<IActionResult> ByMovie(int id)
    {
        var screenings = await _httpClient.GetFromJsonAsync<List<ScreeningViewModel>>($"api/screenings/movie/{id}");
        return View(screenings);
    }
}