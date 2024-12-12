using Microsoft.AspNetCore.Mvc;
using Pendik.ProductManagment.Models.Dtos.Products;

namespace Pendik.ProductManagment.Views.Shared.ViewComponents;

public class ProductTableViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(List<ProductResponseDto> products)
    {
        return View(products);
    }
}