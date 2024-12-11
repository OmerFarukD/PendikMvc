namespace Pendik.ProductManagment.Models.Dtos.Categories;


// record: Immutable yapıdadır yani veri bir kere tanımlandıysa değiştirilemez.
public sealed record CategoryAddRequestDto(string Name);