class Sold : Process {
    public Sold(int id, Product product, int quantity) : base(id, product, quantity) { }

    public override void Update() {
        product.UpdateQuantity(-quantity);
    }
}