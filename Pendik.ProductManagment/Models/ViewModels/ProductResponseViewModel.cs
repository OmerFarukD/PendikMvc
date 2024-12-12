using Pendik.ProductManagment.Models.Dtos.Products;

namespace Pendik.ProductManagment.Models.ViewModels;

public class ProductResponseViewModel
{
    public List<ProductResponseDto> Products { get; set; }

    public int Count => Products.Count;

    public string MostExpensiveProduct => Products.OrderBy(x => x.Price).LastOrDefault().Name;
    
    public string CheapestProduct=> Products.OrderBy(x => x.Price).FirstOrDefault().Name;


    public decimal Total => Products.Sum(x => x.Price);
}