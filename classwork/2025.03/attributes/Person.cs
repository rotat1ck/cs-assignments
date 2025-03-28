[Serializable]
class Person {
    public string? Name { get; set; }
    public int Age { get; set; }
    int _identNum;

    [NonSerialized]
    const string Planet = "Earth";
}