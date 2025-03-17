class Plane {
    public string? Name { get; set; }
    public string? Manifacturer { get; set; }
    public DateTime Date { get; set; }
    public string? Type { get; set; }

    public Plane() {}

    public Plane(string name, string manifacturer, DateTime date, string type) {
        Name = name;
        Manifacturer = manifacturer;
        Date = date;
        Type = type;
    }

    public string? GetName() => Name;
    public string? GetManifacturer() => Manifacturer;
    public DateTime GetDate() => Date;
    public string? GetPlaneType() => Type;

    public override string ToString() {
        return $"Name: {Name}, Manifacturer: {Manifacturer}, Date of manifacture: {Date.Year}, Plane type: {Type}";
    }
}