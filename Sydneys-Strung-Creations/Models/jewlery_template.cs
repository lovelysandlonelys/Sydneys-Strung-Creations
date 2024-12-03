using System.ComponentModel.DataAnnotations;

namespace Sydneys_Strung_Creations.Models
{
    public class jewlery_template
    {
        [Key]
        public int Id { get; set; }
        public string JewleryTemplateURL { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Category { get; set; }
        public float BasePrice { get; set; }
    }
}
