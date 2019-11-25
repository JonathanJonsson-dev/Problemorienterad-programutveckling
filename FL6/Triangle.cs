using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Triangle : Shape
    {
        public int Test { get; set; }
        public Triangle()
        {
             Type = "Triangel";
        }
        public override double Area() //override skriver över grundmetoden.  
        {
            return Height * Width/2.0;
        }
    }
}
