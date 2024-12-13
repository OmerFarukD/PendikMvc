namespace Pendik.ProductManagment.Models;

public sealed class Product
{
    public int Id { get; set; }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public bool IsOnSale { get; set; }
    public Category Category { get; set; }
}