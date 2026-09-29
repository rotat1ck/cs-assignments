namespace validation_practice.Product;

public interface IProductRepository
{
    List<Product> GetProducts();
    Product? GetProductById(int id);
    Product? GetProductByQuery(ProductQuery query);

    void AddProduct(Product product);
    void RemoveProduct(Product product);
}
