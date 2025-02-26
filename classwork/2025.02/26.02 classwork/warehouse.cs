class Warehouse {
    public Warehouse() {}

    public void AddProduct(Product product, int quantity) {
        product.UpdateQuantity(quantity);
    }

    public void RemoveProduct(Product product, int quantity) {
        if (product.quantity >= quantity) {
            product.UpdateQuantity(-quantity);
        } else {
            throw new Excep($"Not enough quantity of {product.name}");
        }
    }
    
    public int GetProductQuantity(Product product) {
        return product.quantity;
    }
}

class Product {
    public string name { get; private set;}
    public int quantity { get; private set;}

    public Product(string name, int quantity) {
        this.name = name;
        this.quantity = quantity;
    }

    public void UpdateQuantity(int quantity) {
        this.quantity += quantity;
    }
}