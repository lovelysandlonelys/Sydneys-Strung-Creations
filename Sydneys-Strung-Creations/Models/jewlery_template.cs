﻿using Sydneys_Strung_Creations.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Sydneys_Strung_Creations.Models
{
    public class jewlery_template
    {
        [Key]
        public int Id { get; set; }
        public string JewleryTemplatePath { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public JewleryCategory JewleryCategory { get; set; }
        public float BasePrice { get; set; }
    }
}
