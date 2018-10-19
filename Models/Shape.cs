using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    /// <summary>
    /// Spape that consists 4 sides
    /// </summary>
    public class Shape
    {
        [Display(Name = "First Side")]
        [Range(1, 2147483647, ErrorMessage = "Number must be morethan 0 and lessthan 2147483648")]
        [Required]
        public int Side1 { get; set; } = 0;

        [Display(Name = "Second Side")]
        [Range(1, 2147483647, ErrorMessage = "Number must be morethan 0 and lessthan 2147483648")]
        [Required]
        public int Side2 { get; set; } = 0;

        [Display(Name = "Third Side")]
        [Range(1, 2147483647, ErrorMessage = "Number must be morethan 0 and lessthan 2147483648")]
        [Required]
        public int Side3 { get; set; } = 0;

        [Display(Name = "Fourth Side")]
        [Range(1, 2147483647, ErrorMessage = "Number must be morethan 0 and lessthan 2147483648")]
        [Required]
        public int Side4 { get; set; } = 0;

        public bool IsValidShape()
        {
            return 
                Side1 > 0 
                && Side2 > 0 
                && Side3 > 0 
                && Side4 > 0;
        }
    }
}