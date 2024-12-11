using Pendik.ProductManagment.Models;

namespace Pendik.ProductManagment.Repository.Abstracts;

public interface IProductRepository
{
    Product Add(Product product);
    Product Update(Product product);
    List<Product> GetAll();
    void Delete(Product product);
    Product? GetById(int id);
    List<Product> GetAllProductsByCategoryId(int id);
    List<Product> GetAllProductsByPriceRange(decimal min , decimal max);
    List<Product> GetAllProductsItIsOnSale(bool itIsOnSale);
    List<Product> GetAllProductsByProductNameContains(string text);
    
    

}