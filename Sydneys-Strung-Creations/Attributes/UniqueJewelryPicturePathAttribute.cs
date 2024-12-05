using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Sydneys_Strung_Creations.Data;

namespace Sydneys_Strung_Creations.Attributes
{
    public class UniqueJewelryPicturePathAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var dbContext = validationContext.GetService<AppDbContext>();
            var picturePath = value.ToString();

            if (dbContext.gallary_listing.Any(g => g.JewleryPicturePath == picturePath))
            {
                return new ValidationResult("The picture path is already in use. Please choose a different one.");
            }

            return ValidationResult.Success;
        }
    }

    public class UniqueProductName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var dbContext = validationContext.GetService<AppDbContext>();
            var productName = value.ToString();

            if (dbContext.gallary_listing.Any(g => g.ProductName == productName))
            {
                return new ValidationResult("The product name is already in use. Please choose a different one.");
            }

            return ValidationResult.Success;
        }
    }
}
