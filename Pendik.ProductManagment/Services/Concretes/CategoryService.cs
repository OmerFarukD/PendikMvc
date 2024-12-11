using AutoMapper;
using Pendik.ProductManagment.Models;
using Pendik.ProductManagment.Models.Dtos.Categories;
using Pendik.ProductManagment.Repository.Abstracts;
using Pendik.ProductManagment.Services.Abstracts;

namespace Pendik.ProductManagment.Services.Concretes;

public sealed class CategoryService(IMapper _mapper, ICategoryRepository _categoryRepository) : ICategoryService
{
    public CategoryResponseDto GetById(int id)
    {
        Category? category = _categoryRepository.GetById(id);
        var response = _mapper.Map<CategoryResponseDto>(category);
        return response;
    }

    public List<CategoryResponseDto> GetAllCategories()
    {
        List<Category> categories = _categoryRepository.GetAll();
        var response = _mapper.Map<List<CategoryResponseDto>>(categories);
        return response;
    }

    public CategoryResponseDto Update(CategoryUpdateRequestDto dto)
    {
        var category = _mapper.Map<Category>(dto);
        var updated = _categoryRepository.Update(category);
        var response = _mapper.Map<CategoryResponseDto>(updated);
        return response;
    }

    public CategoryResponseDto Add(CategoryAddRequestDto dto)
    {
        var category = _mapper.Map<Category>(dto);
        var added = _categoryRepository.Add(category);

        var response = _mapper.Map<CategoryResponseDto>(added);

        return response;
    }

    public void Delete(int id)
    {
        var category = _categoryRepository.GetById(id);
        _categoryRepository.Delete(category);
    }
    
    
}