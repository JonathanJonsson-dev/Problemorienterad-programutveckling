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

        // skapa slumpgenerator
        private Random random = new Random();

        // publika properties
        /// <summary>
        /// Game category one
        /// </summary>
        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int Bonus { get; set; }
        public int Total { get; set; }






        /// <summary>
        /// Check if a score is valid for this category
        /// </summary>
        /// <returns></returns>
        public bool IsValidScore(int score, int category)
        {
            // kollar extremvärden
            int dicesCount = 5;
            if (score < 0 || score > category * dicesCount)
            {
                return false;
            }

            else if (score % category != 0)
            {
                return false;
            }
            return true;
        }

        private bool IsCategoryAvailable(int category)
        {
            switch (category)
            {
                case 1:
                    if (Ones == 0)
                    {
                        return true;
                    }
                    break;
            }
            return false;

        }



        public bool SaveScore(int score, int category)
        {
            // ! vänder på min if sats, alltså inte är okej
            if (!IsValidScore(score, category))
            {
                return false;
            }
            else if (!IsCategoryAvailable(category))
            {
                return false;
            }
            else
            {
                // switch, samma som många if satser
                switch (category)
                {
                    case 1:
                        Ones = score;
                        break;
                    case 2:
                        Twos = score;
                        break;
                    case 3:
                        Threes = score;
                        break;
                    case 4:
                        Fours = score;
                        break;
                    case 5:
                        Fives = score;
                        break;
                    case 6:
                        Sixes = score;
                        break;
                }
                return true;
            }

        }




        public int RoleDie()
        {
            // instansvariabel
            Random random = new Random(); //slumpgenerator
            return random.Next(1, 7);
        }

        public int[] RoleDices()
        {
            int[] dices = new int[5];
            for (int i = 0; i < 5; i++)
            {
                dices[i] = RoleDie();
            }
            return dices;
        }


    }
}
