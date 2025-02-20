class Food : Product {
    public Food(int id, string name, double price, int quantity) : base(id, name, price, quantity) { }
    
    public override void UpdateQuantity(int quantity) {
        this.quantity += quantity;
    }
}