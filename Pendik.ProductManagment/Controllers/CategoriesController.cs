using Microsoft.AspNetCore.Mvc;
using Pendik.ProductManagment.Models.Dtos.Categories;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Controllers;

public class CategoriesController(ICategoryService _categoryService) : Controller
{
    // GET
    public IActionResult Index()
    {
        List<CategoryResponseDto> categories = _categoryService.GetAllCategories();
        return View(categories);
    }


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CategoryAddRequestDto dto)
    {
        var response = _categoryService.Add(dto);

        return RedirectToAction("Index","Categories");
    }


    public IActionResult Delete(int id)
    {
        _categoryService.Delete(id);
        return RedirectToAction("Index", "Categories");
    }


    [HttpGet]
    public IActionResult Update(int id)
    {
        return View();
    }

    public IActionResult Update(CategoryUpdateRequestDto dto)
    {
        var response = _categoryService.Update(dto);
        return RedirectToAction("Index", "Categories");
    }
    
    
    
}