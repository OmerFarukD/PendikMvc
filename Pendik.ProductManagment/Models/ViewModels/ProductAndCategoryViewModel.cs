using Pendik.ProductManagment.Models.Dtos.Categories;
using Pendik.ProductManagment.Models.Dtos.Products;

namespace Pendik.ProductManagment.Models.ViewModels;

public record ProductAndCategoryViewModel(List<ProductResponseDto> Products, List<CategoryResponseDto> Categories);