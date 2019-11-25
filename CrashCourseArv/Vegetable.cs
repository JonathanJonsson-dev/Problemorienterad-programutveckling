using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseArv
{
    class Vegetable
    {
        // Egenskaper
        public decimal Price { get; set; } // decimal högre precision än double, pengar bör vara decimal
        
        // Kan ge metoder

            // Vi är ute efter ett beteende. 
        public virtual string Chop()
        {
            // Kod för att hacka grönsaker 
            return "Hackad";

            // grönsakerna hackas olika


        }

    }
}
