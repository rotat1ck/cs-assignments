class City {
    public string? Name { get; set; }
    public string? Country { get; set; }
    public int Population { get; set; }
    public string? PhoneCode { get; set; }
    public string[]? Districts { get; set; }

    public City() {}

    public City(string name, string country, int population, string phoneCode, string[] districts) {
        Name = name;
        Country = country;
        Population = population;
        PhoneCode = phoneCode;
        Districts = districts;
    }

    public string? GetName() => Name;

    public string? GetCountry() => Country;

    public int GetPopulation() => Population;

    public string? GetPhoneCode() => PhoneCode;

    public string[]? GetDistricts() => Districts;

    public override string ToString() {
        return $"Name: {Name}, Country: {Country}, Population: {Population}, PhoneCode: {PhoneCode}, Districts: {string.Join(", ", Districts)}";
    }
}