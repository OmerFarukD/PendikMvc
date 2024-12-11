namespace Pendik.ProductManagment.Models.Dtos.Products;

public sealed record ProductAddRequestDto(string Name, int CategoryId, decimal Price, bool IsOnSale, int Stock);