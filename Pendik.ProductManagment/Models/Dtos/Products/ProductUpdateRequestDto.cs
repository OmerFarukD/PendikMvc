namespace Pendik.ProductManagment.Models.Dtos.Products;

public sealed record ProductUpdateRequestDto(int Id,string Name, int CategoryId, decimal Price, bool IsOnSale, int Stock);