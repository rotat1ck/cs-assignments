using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace page_handlers.Pages;

public class ProductsModel : PageModel
{
    private static List<Product> _products =
    [
        new Product
        {
            Id = 1,
            Name = "First",
            Price = 100
        },
        new Product
        {
            Id = 2,
            Name = "Second",
            Price = 200
        },
        new Product
        {
            Id = 3,
            Name = "Third",
            Price = 300
        }
    ];

    public List<Product> Products { get; set; } = [];
    public Product? SelectedProduct;

    [BindProperty]
    public Product NewProduct { get; set; } = new();

    public void OnGet()
    {
        Products = _products;
    }

    public RedirectToPageResult OnPostAdd()
    {
        if (ModelState.IsValid)
        {
            _products.Add(NewProduct);
        }

        return RedirectToPage();
    }

    public void OnGetById(int id)
    {
        SelectedProduct = _products.FirstOrDefault(product => product.Id == id);
    }

    public void OnGetByPriceMin(decimal minPrice)
    {
        Products = _products.Where(product => product.Price >= minPrice).ToList();
    }

    public void OnGetByPriceMax(decimal maxPrice)
    {
        Products = _products.Where(product => product.Price <= maxPrice).ToList();
    }
}
