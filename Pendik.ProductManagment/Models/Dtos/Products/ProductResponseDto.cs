namespace Pendik.ProductManagment.Models.Dtos.Products;

public sealed record ProductResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string CategoryName { get; init; }
    public decimal Price { get; init; }
    public bool IsOnSale { get; init; }
    public int  Stock { get; init; }
}