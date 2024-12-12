using Microsoft.AspNetCore.Mvc;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Views.Shared.ViewComponents;

public class CategoryListViewComponent(ICategoryService categoryService) : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var response = categoryService.GetAllCategories();
        return View(response);
    }
}