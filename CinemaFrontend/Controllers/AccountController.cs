using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CinemaFrontend.Controllers;

public class AccountController : Controller
{
    // Hårdkodade inloggningsuppgifter för adminkontot.
    private const string AdminUsername = "Admin";
    private const string AdminPassword = "SOS100";

    // Visar inloggningssidan.
    public IActionResult Login()
    {
        return View();
    }

    // Hanterar inloggning.
    [HttpPost]
    public async Task<IActionResult> Login(string username, string password)
    {
        if (username == AdminUsername && password == AdminPassword)
        {
            // Skapar en lista med användarens uppgifter.
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username) // Lagrar användarnamnet i listan.
            };

            // Skapar en identitet baserat på listan.
            var identity = new ClaimsIdentity(claims, "Cookies");
            // Skapar ett objekt som representerar den inloggade användaren, används av [Authorize] för att kontrollera om användaren är inloggad.
            var principal = new ClaimsPrincipal(identity);

            // Sparar identiteten som en cookie i webbläsaren.
            await HttpContext.SignInAsync("Cookies", principal);

            return RedirectToAction("Index", "Movies");
        }

        ViewBag.Error = "Fel användarnamn eller lösenord.";
        return View();
    }

    // Loggar ut användaren.
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync("Cookies");
        return RedirectToAction("Login");
    }
}