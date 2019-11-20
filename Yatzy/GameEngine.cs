using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class GameEngine
    {
        // accessors

        // private och public

        // uppdrag: gör en metod som kastar en tärning
        public int RoleDie()
        {
            // instansvariabel
            Random random = new Random(); //slumpgenerator
            return random.Next(1, 7);
        }

    }
}
