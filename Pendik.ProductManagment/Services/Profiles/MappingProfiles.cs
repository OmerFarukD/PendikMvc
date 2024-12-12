using AutoMapper;
using Pendik.ProductManagment.Models;
using Pendik.ProductManagment.Models.Dtos.Categories;
using Pendik.ProductManagment.Models.Dtos.Products;

namespace Pendik.ProductManagment.Services.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CategoryAddRequestDto, Category>();
        CreateMap<CategoryUpdateRequestDto, Category>().ReverseMap();
        CreateMap<Category, CategoryResponseDto>();


        CreateMap<ProductAddRequestDto, Product>();
        CreateMap<ProductUpdateRequestDto, Product>().ReverseMap();
       // CreateMap<Product, ProductUpdateRequestDto>();
        CreateMap<Product, ProductResponseDto>();
    }
}