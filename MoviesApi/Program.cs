using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Kopplar databasen till applikationen med SQLite och anger filnamnet.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=cinema.db"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.MapControllers();

// Säkerställer att databasen finns och är uppdaterad innan appen startar.
// Viktigt inför Azure-driftsättning då det inte finns någon lokal databas där.
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

app.Run();