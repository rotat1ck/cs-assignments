class Laptop {
    public string Vendor { get; set; }
    public double Price { get; set; }

    public override string ToString() {
        return $"{Vendor} {Price}";
    }
}