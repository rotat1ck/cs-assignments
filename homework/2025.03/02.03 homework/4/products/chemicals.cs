class Chemicals : Product {
    public string Brand;

    public Chemicals(int id, string name, double price, int quantity, string brand)
        : base(id, name, price, quantity){
        Brand = brand;
    }

    public override void UpdateQuantity(int quantity) {
        this.quantity += quantity;
    }
}