using Pendik.ProductManagment.Models;

namespace Pendik.ProductManagment.Repository.Abstracts;

public interface ICategoryRepository
{
    Category Add(Category category);
    Category Update(Category category);
    Category? GetById(int id);
    List<Category> GetAll();
    void Delete(Category category);
}