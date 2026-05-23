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
    client.BaseAddress = new Uri("https://movies-api-christoffer-fbgmaagbeqc2e9gy.norwayeast-01.azurewebsites.net/");
});

// Kopplar samman ScreeningsApi med bas-URL för HTTP-anrop.
builder.Services.AddHttpClient("ScreeningsApi", client =>
{
    client.BaseAddress = new Uri("https://screenings-api-christoffer-esgxh0e7e0ffhrcz.norwayeast-01.azurewebsites.net/");
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