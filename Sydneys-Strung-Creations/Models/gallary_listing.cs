using System.ComponentModel.DataAnnotations;
using Sydneys_Strung_Creations.Data.Enums;


namespace Sydneys_Strung_Creations.Models
{
    public class gallary_listing
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Picture")]
        public string JewleryPicturePath { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Description")]
        public string ProductDescription { get; set; }
        [Display(Name = "Category")]
        public JewleryCategory JewleryCategory { get; set; }
        [Display(Name = "Primary Color")]
        public FocalColor FocalColor { get; set; }
    }
}
