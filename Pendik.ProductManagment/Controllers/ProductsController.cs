using Microsoft.AspNetCore.Mvc;
using Pendik.ProductManagment.Models.Dtos.Categories;
using Pendik.ProductManagment.Models.Dtos.Products;
using Pendik.ProductManagment.Models.ViewModels;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Controllers;

public class ProductsController(IProductService _productService) : Controller
{
    public IActionResult Index()
    {
        List<ProductResponseDto> products = _productService.GetAll();

        ProductResponseViewModel viewModel = new ProductResponseViewModel()
        {
            Products = products
        };

   
        return View(viewModel);
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


    [HttpGet]
    public IActionResult Detail(int id)
    {
        var response = _productService.GetById(id);
        
        return View(response);
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var response = _productService.GetByIdForUpdateRequest(id);
        return View(response);
    }


    [HttpPost]
    public IActionResult Edit(ProductUpdateRequestDto dto)
    {
        var response = _productService.Update(dto);
        return RedirectToAction("Index", "Products");
    }


    [HttpGet]
    public IActionResult GetAllByCategoryId(int categoryId)
    {
        var response = _productService.GetAllProductsByCategoryId(categoryId);
        ProductResponseViewModel viewModel = new ProductResponseViewModel()
        {
            Products = response
        };

   
        return View(viewModel);
    }


    public IActionResult GetAllByIsOnSale(bool isOnSale)
    {
        var products = _productService.GetAllProductsItIsOnSale(isOnSale);
        ProductResponseViewModel viewModel = new()
        {
            Products = products
        };
        return View(viewModel);
    }
    
}