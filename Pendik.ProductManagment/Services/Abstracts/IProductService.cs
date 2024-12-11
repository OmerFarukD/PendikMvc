using Pendik.ProductManagment.Models.Dtos.Products;

namespace Pendik.ProductManagment.Services.Abstracts;

public interface IProductService
{
    ProductResponseDto Add(ProductAddRequestDto dto);
    ProductResponseDto Update(ProductUpdateRequestDto dto);
    List<ProductResponseDto> GetAll();
    void Delete(int id);
    ProductResponseDto GetById(int id);
    List<ProductResponseDto> GetAllProductsByCategoryId(int id);
    List<ProductResponseDto> GetAllProductsByPriceRange(decimal min , decimal max);
    List<ProductResponseDto> GetAllProductsItIsOnSale(bool itIsOnSale);
    List<ProductResponseDto> GetAllProductsByProductNameContains(string text);
}