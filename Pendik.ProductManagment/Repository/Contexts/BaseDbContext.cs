using Microsoft.EntityFrameworkCore;
using Pendik.ProductManagment.Models;

namespace Pendik.ProductManagment.Repository.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions<BaseDbContext> opt): base(opt)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}