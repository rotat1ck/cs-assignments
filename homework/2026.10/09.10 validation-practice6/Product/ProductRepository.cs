namespace validation_practice.Product;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> products = [];

    public List<Product> GetProducts()
    {
        return products;
    }

    public Product? GetProductById(int id)
    {
        return products.FirstOrDefault(p => p.Id == id);
    }

    public Product? GetProductByQuery(ProductQuery query)
    {
        var queryProps = query.GetType().GetProperties();
        var productProps = typeof(Product).GetProperties();

        return products.FirstOrDefault(p => queryProps.All(queryProp =>
        {
            var productProp = productProps.FirstOrDefault(productProp => productProp.Name == queryProp.Name);
            if (productProp is null)
            {
                return false;
            }

            if (!Equals(productProp.GetValue(p), queryProp.GetValue(query)))
            {
                return false;
            }

            return true;
        }));
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
}
