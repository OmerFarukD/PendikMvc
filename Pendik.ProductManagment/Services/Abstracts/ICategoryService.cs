using Pendik.ProductManagment.Models.Dtos.Categories;

namespace Pendik.ProductManagment.Services.Abstracts;

public interface ICategoryService
{
    CategoryResponseDto GetById(int id);
    List<CategoryResponseDto> GetAllCategories();
    CategoryResponseDto Update(CategoryUpdateRequestDto dto);
    CategoryResponseDto Add(CategoryAddRequestDto dto);
    void Delete(int id);
    
    CategoryUpdateRequestDto GetByIdForUpdateRequest(int id);
}