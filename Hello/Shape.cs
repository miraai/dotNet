using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class Shape
    {
        public virtual int Perimeter()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Perimeter()
        {
            return (Height + Width) * 2;
        }
    }

    class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public override int Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}
