namespace web_practice4;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", (LinkGenerator links) =>
        {
            return $"""
            Available links:
                
            Random: {links.GetPathByName("random-letter")}
            Person: {links.GetPathByName("person", new { firstName = "Ivanov", lastName = "Ivan" }, options: new LinkOptions { AppendTrailingSlash = false, LowercaseQueryStrings = true })}
            Redirect: {links.GetPathByName("redirect-to-random")}
            """;
        });

        app.MapGet("/random", () =>
        {
            return Alphabet[Random.Shared.Next(0, Alphabet.Count - 1)];
        }).WithName("random-letter");

        app.MapGet("person", (string firstName, string lastName) =>
        {
            return new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = new DateTime(Random.Shared.Next(1980, 2026), Random.Shared.Next(1, 12), Random.Shared.Next(1, 30))
            };
        }).WithName("person");

        app.MapGet("redirect-me", (LinkGenerator links) =>
        {
            return Results.RedirectToRoute("random-letter");
        }).WithName("redirect-to-random");

        app.Run();
    }

    private readonly static List<char> Alphabet = GetAlphabet();

    private static List<char> GetAlphabet()
    {
        List<char> alph = [];

        for (char c = 'A'; c <= 'Z'; ++c)
        {
            alph.Add(c);
        }

        return alph;
    }
}
