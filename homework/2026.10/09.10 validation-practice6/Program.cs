using validation_practice.Product;

namespace validation_practice;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // заместо WithParameterValidation
        builder.Services.AddValidation();

        builder.Services.AddSingleton<IProductRepository, ProductRepository>();
        builder.Services.AddAuthorization();

        var app = builder.Build();

        app.MapPost("product", (Product.Product product, IProductRepository repository) =>
        {
            repository.AddProduct(product);
            return Results.Created();
        });

        app.MapGet("products", (IProductRepository repository) =>
        {
            return repository.GetProducts();
        });

        app.MapGet("product", ([AsParameters] ProductQuery query, IProductRepository repository) =>
        {
            var result = repository.GetProductByQuery(query);
            if (result is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(result);
        });

        app.Run();
    }
}
