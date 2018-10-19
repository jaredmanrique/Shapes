using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ViewModel
{
    public class ShapeViewModel : Shape
    {
        public string ShapeType { get; set; }

        public ShapeViewModel(Shape shape)
        {
            this.Side1 = shape.Side1;
            this.Side2 = shape.Side2;
            this.Side3 = shape.Side3;
            this.Side4 = shape.Side4;
            this.ShapeType = string.Empty;
        }
        public ShapeViewModel()
        {
            this.Side1 = 0;
            this.Side2 = 0;
            this.Side3 = 0;
            this.Side4 = 0;
            this.ShapeType = string.Empty;
        }
    }
}
