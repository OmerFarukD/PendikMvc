using System.ComponentModel.DataAnnotations;

namespace Pendik.ProductManagment.Attributes.Validations;

public class ZeroAndNegativeValuesCheckAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is int || value is decimal || value is double)
        {
            double deger = Convert.ToDouble(value);

            if (deger <= 0)
            {
                return new ValidationResult("Girmiş olduğunuz değer 0 veya negatif değer alamaz.");
            }

        }

        return ValidationResult.Success;
    }

}