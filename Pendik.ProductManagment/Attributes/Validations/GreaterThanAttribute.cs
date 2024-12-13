using System.ComponentModel.DataAnnotations;

namespace Pendik.ProductManagment.Attributes.Validations;

public class GreaterThanAttribute : ValidationAttribute
{
    public double Value { get; set; } = 10;


    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is double || value is int || value is decimal)
        {
            double deger = Convert.ToDouble(value);

            if (Value>deger)
            {
                return new ValidationResult($"Değer {Value} değerinden büyük olmalıdır. ");
            }
        }
        return ValidationResult.Success;
    }
}