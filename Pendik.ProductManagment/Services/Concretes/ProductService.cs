using AutoMapper;
using Pendik.ProductManagment.Models;
using Pendik.ProductManagment.Models.Dtos.Products;
using Pendik.ProductManagment.Repository.Abstracts;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Services.Concretes;

public class ProductService(IProductRepository _productRepository, IMapper _mapper) : IProductService
{
    public ProductResponseDto Add(ProductAddRequestDto dto)
    {
        Product product = _mapper.Map<Product>(dto);
        var created = _productRepository.Add(product);
        var reponse = _mapper.Map<ProductResponseDto>(created);
        return reponse;
    }

    public ProductResponseDto Update(ProductUpdateRequestDto dto)
    {
        Product product = _mapper.Map<Product>(dto);
        var updated = _productRepository.Update(product);
        var reponse = _mapper.Map<ProductResponseDto>(updated);
        return reponse;
    }

    public List<ProductResponseDto> GetAll()
    {
        List<Product> products = _productRepository.GetAll();
        var response = _mapper.Map<List<ProductResponseDto>>(products);
        return response;
    }

    public void Delete(int id)
    {
        Product? product = _productRepository.GetById(id);
        _productRepository.Delete(product);
        
    }

    public ProductResponseDto GetById(int id)
    {
        Product? product = _productRepository.GetById(id);

        var response = _mapper.Map<ProductResponseDto>(product);

        return response;
    }

    public List<ProductResponseDto> GetAllProductsByCategoryId(int id)
    {
        List<Product> products = _productRepository.GetAllProductsByCategoryId(id);
        var response = _mapper.Map<List<ProductResponseDto>>(products);
        return response;
    }

    public List<ProductResponseDto> GetAllProductsByPriceRange(decimal min, decimal max)
    {
        List<Product> products = _productRepository.GetAllProductsByPriceRange(min,max);
        var response = _mapper.Map<List<ProductResponseDto>>(products);
        return response;
    }

    public List<ProductResponseDto> GetAllProductsItIsOnSale(bool itIsOnSale)
    {
        List<Product> products = _productRepository.GetAllProductsItIsOnSale(itIsOnSale);
        var response = _mapper.Map<List<ProductResponseDto>>(products);
        return response;
    }

    public List<ProductResponseDto> GetAllProductsByProductNameContains(string text)
    {
        List<Product> products = _productRepository.GetAllProductsByProductNameContains(text);
        var response = _mapper.Map<List<ProductResponseDto>>(products);
        return response;
    }

    public ProductUpdateRequestDto GetByIdForUpdateRequest(int id)
    {
        Product? product = _productRepository.GetById(id);

        var request = _mapper.Map<ProductUpdateRequestDto>(product);

        return request;
    }
}