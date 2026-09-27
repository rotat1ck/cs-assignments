namespace web_practice4;

public class Person
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string[]? AdditionalData { get; set; }
}
