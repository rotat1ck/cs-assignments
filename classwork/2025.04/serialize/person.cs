[Serializable]
public class Person {
    public string? Name { get; set; }
    public int Age { get; set; }
    private int _identityNumber;

    public Person() { }

    public Person(string? name, int age) {
        Name = name;
        Age = age;
    }

    [NonSerialized]
    public const string Planet = "Земля";

    public override string ToString() { 
        return $"Name - {Name}, Age - {Age}, Id - {_identityNumber} " + $"Planet - {Planet}"; 
    }
}