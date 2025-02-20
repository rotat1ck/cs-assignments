abstract class Product {
    public int id;
    public string name;
    public double price;
    public int quantity;

    public Product(int id, string name, double price, int quantity) {
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public abstract void UpdateQuantity(int quantity);
}