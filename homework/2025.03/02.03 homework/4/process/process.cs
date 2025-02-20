abstract class Process {
    public int id;
    public Product product;
    public int quantity;

    public Process(int id, Product product, int quantity) {
        this.id = id;
        this.product = product;
        this.quantity = quantity;
    }

    public abstract void Update();
}