using Microsoft.AspNetCore.Mvc;
using Pendik.ProductManagment.Models.Dtos.Products;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Controllers;

public class ProductsController(IProductService _productService) : Controller
{
    public IActionResult Index()
    {
        List<ProductResponseDto> responses = _productService.GetAll();
        
        return View(responses);
    }


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ProductAddRequestDto dto)
    {
        var response = _productService.Add(dto);
        return RedirectToAction("Index", "Products");
    }
    
    
    
}