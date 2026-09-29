namespace validation_practice.Product;

public record struct ProductQuery(
    int Id,
    string Name,
    bool IsAvailable = true
);
