using Microsoft.EntityFrameworkCore;
using Pendik.ProductManagment.Models;
using Pendik.ProductManagment.Repository.Abstracts;
using Pendik.ProductManagment.Repository.Contexts;

namespace Pendik.ProductManagment.Repository.Concretes;

public sealed class ProductRepository(BaseDbContext _context) : IProductRepository
{
    public Product Add(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();

        return product;
    }

    public Product Update(Product product)
    {
        _context.Products.Update(product);
        _context.SaveChanges();

        return product;
    }

    public List<Product> GetAll()
    {
        return _context.Products.Include(x=>x.Category).ToList();
        
        // Id: 1,
        // NAME : tarantula_umut,
        //price: 
        // Category: null
    }

    public void Delete(Product product)
    {
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public Product? GetById(int id)
    {
        return _context.Products.Include(x=>x.Category).SingleOrDefault(x=>x.Id==id);
    }

    public List<Product> GetAllProductsByCategoryId(int id)
    {
        return _context.Products
            .AsNoTracking()
            .Where(x => x.CategoryId == id)
            .Include(x => x.Category)
            .ToList();
    }

    public List<Product> GetAllProductsByPriceRange(decimal min, decimal max)
    {
        return _context.Products
            .AsNoTracking()
            .Where(x => x.Price <= max && x.Price >= min)
            .Include(x => x.Category)
            .ToList();
    }

    public List<Product> GetAllProductsItIsOnSale(bool itIsOnSale)
    {
        return _context.Products
            .AsNoTracking()
            .Where(x => x.IsOnSale == itIsOnSale)
            .Include(x=>x.Category)
            .ToList();
    }

    public List<Product> GetAllProductsByProductNameContains(string text)
    {
        return _context.Products
            .AsNoTracking()
            .Where(x => x.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            .Include(x=>x.Category)
            .ToList();
    }
}