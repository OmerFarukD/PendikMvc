using Pendik.ProductManagment.Models;
using Pendik.ProductManagment.Repository.Abstracts;
using Pendik.ProductManagment.Repository.Contexts;

namespace Pendik.ProductManagment.Repository.Concretes;

public sealed class CategoryRepository(BaseDbContext _context) : ICategoryRepository
{
    public Category Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();

        return category;
    }

    public Category Update(Category category)
    {
        _context.Categories.Update(category);
        _context.SaveChanges();

        return category;
    }

    public Category? GetById(int id)
    {
        return _context.Categories.Find(id);
    }

    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public void Delete(Category category)
    {
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }
}