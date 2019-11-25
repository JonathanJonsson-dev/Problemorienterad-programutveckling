using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL6
{
    class Shape
    {
        // Basklass som hanterar våra figurer
        // Vår förälder
        
        public double Height { get; set; }
        public double Width { get; set; }
        public string Type { get; set; }
        // skape en grundmetod använd om du vill eller ändra om du måste 
        // polyformism = att en och samma metod kan ha olika skepnader 
        public virtual double Area() //vortual == grundmetod 
        {
            return Height * Width;
        }

    }
}
