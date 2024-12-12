using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Pendik.ProductManagment.Models.ViewModels;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Views.Shared.ViewComponents;

public class CategorySelectListViewComponent(ICategoryService _categoryService) : ViewComponent
{
    public IViewComponentResult Invoke(int? categoryId = null)
    {
        var categories = _categoryService.GetAllCategories();
        var selectList = categories.Select(c => new SelectListItem()
        {
            Value = c.Id.ToString(),
            Text = c.Name
        });

        var viewModel = new CategorySelectListViewModel()
        {
            Categories = selectList,
            CategoryId = categoryId
        };
        return View(viewModel);
    }
}