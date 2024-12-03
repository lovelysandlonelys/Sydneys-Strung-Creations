using System.ComponentModel.DataAnnotations;
using Sydneys_Strung_Creations.Data.Enums;


namespace Sydneys_Strung_Creations.Models
{
    public class gallary_listing
    {
        [Key]
        public int Id { get; set; }
        public string JewleryPictureURL { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public JewleryCategory JewleryCategory { get; set; }
    }
}
