namespace minimal_api_practice3.Songs;

public class Song
{
    public required string Title { get; set; }
    public required string Artist { get; set; }
    public required int Year { get; set; }
    public string[]? Lyrics { get; set; }
}
