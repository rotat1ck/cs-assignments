class Programmer {
    protected Product? product;
    public string? code;
    public void Operation(string code) {
        this.code = code;
        Console.WriteLine($"Programmer: {code}");
    }
}