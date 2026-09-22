using minimal_api_practice3.Drinks;
using minimal_api_practice3.Songs;

namespace minimal_api_practice3;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/drinks/{drinkType}", ReflectDrink);

        Song[] songs =
        [
            new Song
            {
                Title = "Liaison",
                Artist = "Jamie Paige",
                Year = 2024
            },
            new Song
            {
                Title = "DIALTONE",
                Artist = "rj lake",
                Year = 2026
            },
            new Song
            {
                Title = "Human",
                Artist = "FLAVOR FOLEY",
                Year = 2025
            }
        ];

        app.MapGet("/songs", () =>
        {
            return songs;
        });

        app.MapGet("/songs/{songTitle}", (string songTitle) =>
        {
            return songs.Where(s => s.Title.Contains(songTitle, StringComparison.InvariantCultureIgnoreCase));
        });

        app.Run();
    }

    private static object ReflectDrink(string drinkType)
    {
        var type = Type.GetType($"minimal_api_practice3.Drinks.{drinkType}", throwOnError: false, ignoreCase: true);
        if (type is null || type.IsAbstract)
        {
            return Results.NotFound(new { Error = "Drink type not found" });
        }

        var vehicle = Activator.CreateInstance(type) as Drink;
        return new
        {
            Title = vehicle.Title
        };
    }
}
