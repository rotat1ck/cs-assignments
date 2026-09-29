using System.ComponentModel.DataAnnotations;

namespace validation_practice.Product;

public class Product
{
    [Required]
    public int Id { get; set; }

    [Required]
    [StringLength(64, ErrorMessage = "Длина названия продукта не может быть больше 64")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(0.0, int.MaxValue, ErrorMessage = "Цена не может быть негативной")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(64, ErrorMessage = "Длина названия категории не может быть больше 64")]
    public string Category { get; set; } = string.Empty;

    public bool IsAvailable { get; set; } = true;
}
