using System.ComponentModel.DataAnnotations;
using Pendik.ProductManagment.Attributes.Validations;

namespace Pendik.ProductManagment.Models.Dtos.Products;

public sealed record ProductUpdateRequestDto(int Id,
[MaxLength(20,ErrorMessage = "Maximum 20 hane içermelidir.")]
[Display(Name = "Ürün Adı")]
[Required(ErrorMessage = "İsim Alanı Zorunludur")]
string Name,
    
    
[ZeroAndNegativeValuesCheck]
int CategoryId,
    
//[Range(minimum:1,maximum:250000,ErrorMessage = "0 ile 250000 aralığında olmalıdır.")]
[Display(Name = "Ürün Değeri")]
[Required(ErrorMessage = "Ürün Değeri Alanı Zorunludur.")]
[GreaterThan(Value = 5)]
decimal? Price,
    
bool IsOnSale,
    
[Range(minimum:1,maximum:300000,ErrorMessage = "0 ile 300000 aralığında olmalıdır.")]
[Display(Name = "Stok Adedi")]
[Required(ErrorMessage = "Ürün Değeri Alanı Zorunludur.")]
int? Stock
    );