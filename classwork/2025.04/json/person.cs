using System.Text.Json.Serialization;
class Person {
    [JsonPropertyName("first")]
    public string? Name { get; }

    [JsonIgnore]
    public int Age { get; set; }

    public Person(string name) {
        Name = name;
    }
    
    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}