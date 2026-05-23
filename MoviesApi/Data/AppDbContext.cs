using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;

namespace MoviesApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }

    // Definierar seed-data som läggs in i databasen när migrationen körs. Detta för att slippa manuellt lägga in test data varje gång db byggs om.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 2,
                Title = "The Mummy",
                Director = "Lee Cronin",
                Actors = "Jack Reynor, Laia Costa, Hayat Kamille",
                OriginalTitle = "Lee Cronin's The Mummy",
                OriginalLanguage = "Engelska",
                Genre = "Skräck",
                AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.",
                DurationMinutes = 134,
                Premiere = new DateOnly(2026, 4, 17),
                Price = 169,
                IsShowing = true,
                Description = "En familj stöter på en uråldrig mumie i denna nya tolkning av det klassiska monstret.",
                ImageUrl = "/images/mummy.jpg",
            },
            new Movie
            {
                Id = 4,
                Title = "Obsession",
                Director = "Curry Barker",
                Actors = "Michael Johnston, Inde Navarrette, Andy Richter, Cooper Tomlinson, Megan Lawless, Haley Fitzgerald, Darin Toonder, Chloe Breen, Anthony Pavone",
                OriginalTitle = "Obsession",
                OriginalLanguage = "Engelska",
                Genre = "Skräck",
                AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.",
                DurationMinutes = 108,
                Premiere = new DateOnly(2026, 5, 15),
                Price = 189,
                IsShowing = true,
                Description = "Efter att ha använt en mystisk \"One Wish Willow\" i hopp om att vinna sin förälskelses hjärta, får en hopplös romantiker precis det han önskar sig. " +
                              "Men han upptäcker snart att för en del önskningar får man betala ett mörkt och fruktansvärt pris.",
                ImageUrl = "/images/obsession.jpg",
            },
            new Movie
            {
                Id = 1,
                Title = "Fårdetektiverna",
                Director = "Kyle Balda",
                Actors = "Hugh Jackman, Emma Thompson, Bella Ramsey",
                OriginalTitle = "The Sheep Detectives",
                OriginalLanguage = "Engelska",
                Genre = "Komedi, Familj, Mysterium",
                AgeRating = "Från 7 år: Får ses på bio av barn under 7 år i vuxens sällskap.",
                DurationMinutes = 109,
                Premiere = new DateOnly(2026, 5, 8),
                Price = 119,
                IsShowing = true,
                Description = "I detta roliga och underhållande mysterium, som inte liknar något du sett tidigare, är George en herde som varje kväll läser deckarromaner för sina älskade får, i tron att de omöjligt kan förstå. " +
                              "Men när en mystisk händelse stör livet på gården inser fåren att de själva måste bli detektiver. När de följer ledtrådarna och undersöker mänskliga misstänkta bevisar de att även får kan vara briljanta brottslösare.",
                ImageUrl = "/images/fardetektiverna.jpg",
            },
            new Movie
            {
                Id = 3,
                Title = "Mortal Kombat II",
                Director = "Simon McQuoid",
                Actors = "Karl Urban, Hiroyuki Sanada, Martyn Ford, Lewis Tan, Damon Herriman, Tati Gabrielle, Adeline Rudolph, Tadanobu Asano, Josh Lawson, " +
                         "Jessica McNamee, Mehcad Brooks, Ludi Lin, Joe Taslim, Chin Han, Ana Thu Nguyen, Desmond Chiam, Julian Weeks, Max Huang, CJ. Bloomfield",
                OriginalTitle = "Mortal Kombat II",
                OriginalLanguage = "Engelska",
                Genre = "Action",
                AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.",
                DurationMinutes = 115,
                Premiere = new DateOnly(2026, 5, 8),
                Price = 159,
                IsShowing = true,
                Description = "Den här gången ställs fansens favorithjältar – nu tillsammans med Johnny Cage själv – mot varandra i den ultimata, " +
                              "och fullständigt skoningslösa, blodiga kampen för att besegra Shao Kahns mörka härskande som hotar själva existensen av Earthrealm och dess försvarare.",
                ImageUrl = "/images/mortalkombat.jpg",
            },
            new Movie
            {
                Id = 5,
                Title = "All You Need Is Kill",
                Director = "Kenichiro Akimoto",
                Actors = "Ai Mikami, Natsuki Hanae, Hiccorohee, Kana Hanazawa, Mô Chûgakusei",
                OriginalTitle = "All You Need Is Kill",
                OriginalLanguage = "Japanska",
                Genre = "Anime",
                AgeRating = "Från 11 år: Får ses på bio av den som fyllt 7 år i sällskap med vuxen.",
                DurationMinutes = 86,
                Premiere = new DateOnly(2026, 5, 29),
                Price = 129,
                IsShowing = false,
                Description = "Rita har hamnat i en tidsloop under en utomjordisk invasion, återupplever samma dag om och om igen och blir långsamt en alltmer effektiv krigare. " +
                              "Utmattad av en oändlig rad av dödsögonblick upptäcker hon Keiji, en annan person som hamnat i samma loop.",
                ImageUrl = "/images/allyouneediskill.jpg",
            },
             new Movie
            {
            Id = 6,
            Title = "Scary Movie",
            Director = "Michael Tiddes",
            Actors = "Marlon Wayans, Shawn Wayans, Anna Faris, Regina Hall, Damon Wayans Jr., Gregg Wayans, Kim Wayans, Benny Zielke, " +
                     "Cameron Scott Roberts, Cheri Oteri, Chris Elliott, Dave Sheridan, Heidi Gardner, Lochlyn Munro",
            OriginalTitle = "Scary Movie",
            OriginalLanguage = "Engelska",
            Genre = "Skräck, Komedi",
            AgeRating = "Från 15 år: Får ses på bio av den som fyllt 11 år i sällskap med vuxen.",
            DurationMinutes = 95,
            Premiere = new DateOnly(2026, 6, 5),
            Price = 159,
            IsShowing = false,
            Description = "26 år efter att ha sprungit ifrån en misstänkt välbekant maskerad mördare (“Ghostface”), är original-fyran måltavla för mördaren igen och ingen skräckfilms-serie går säker. " +
                          "Marlon Wayans (“Shorty”), Shawn Wayans (“Ray”), Anna Faris (“Cindy”) och Regina Hall (“Brenda”) återförenas i Scary Movie, tillsammans med återvändande favoriter och nya ansikten, " +
                          "för att hugga sig igenom reboots, nyinspelningar, reboots på nyinspelningar, prequels, sequels, spin-offs, arthouse-horror, ursprungshistorier, allting som anses vara ikoniskt , och vartenda " +
                          "“sista kapitel” som verkligen inte är det sista.\n\nIngenting är heligt. Inget berättargrepp går säkert. Alla gränser korsas. Bröderna Wayans är tillbaka för att cancellera cancel-kulturen.",
            ImageUrl = "/images/scarymovie.jpg",
            }
        );
    }
}