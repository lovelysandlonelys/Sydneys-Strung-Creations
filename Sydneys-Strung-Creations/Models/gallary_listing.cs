using System.ComponentModel.DataAnnotations;
using Sydneys_Strung_Creations.Attributes;
using Sydneys_Strung_Creations.Data.Enums;


namespace Sydneys_Strung_Creations.Models
{
    public class gallary_listing
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Picture")]
        [Required(ErrorMessage = "Jewlery Picture Path is required.")]
        [UniqueJewelryPicturePath]
        public string JewleryPicturePath { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name is required.")]
        [UniqueProductName]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string ProductDescription { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Jewlery Category is required.")]
        public JewleryCategory JewleryCategory { get; set; }

        [Display(Name = "Primary Color")]
        [Required(ErrorMessage = "Focal Color is required.")]
        public FocalColor FocalColor { get; set; }
    }
}
