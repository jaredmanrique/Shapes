using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    /// <summary>
    /// Spape that consists 4 sides
    /// </summary>
    public class Shape
    {
        public int Side1 { get; set; } = 0;
        public int Side2 { get; set; } = 0;
        public int Side3 { get; set; } = 0;
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