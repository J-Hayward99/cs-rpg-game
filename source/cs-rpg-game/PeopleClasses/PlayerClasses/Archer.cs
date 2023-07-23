using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.PlayerClasses
{
    public class Archer : Player
    {
        public Archer(string aName) : base(aName)
        {
            /*
                Gist:
                    - Unarmoured        (0 )    0
                    - Semi Strong       (+1)    +
                    - Slow              (-2)    -
                    - Default Magic     (+0)    o
                    - Default Luck      (+0)    o
                    - Somewhat Agile    (+1)    +

                    - Net Change        (0 )
            */

            // Stats 
            Health      += 0;
            Strength    += +1;
            Speed       += -2;
            Magic       += 0;
            Luck        += 0;
            Agility     += +1;
            PlayerClass = Enums.PlayerType.Archer;
            
            // Derived Stats
            GenerateDerivedStuff();
        }
    }
}