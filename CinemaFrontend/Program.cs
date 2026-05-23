var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Aktiverar cookie-baserad autentisering med omdirigering till inloggningssidan.
builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Account/Login";
    });

// Kopplar samman MoviesApi med bas-URL för HTTP-anrop.
builder.Services.AddHttpClient("MoviesApi", client =>
{
    client.BaseAddress = new Uri("http://localhost:5250/");
});

// Kopplar samman ScreeningsApi med bas-URL för HTTP-anrop.
builder.Services.AddHttpClient("ScreeningsApi", client =>
{
    client.BaseAddress = new Uri("http://localhost:5130/");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapStaticAssets();

app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();