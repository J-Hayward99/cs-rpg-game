using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.PlayerClasses
{
    public class Serf : Player
    {
        public Serf(string aName) : base(aName)
        {
            /*
                Gist:
                    - Farmer            (0 )    0
                    - Farmerpilled      (+1)    +
                    - Average           (0 )    o
                    - Default Magic     (0 )    o
                    - Default Luck      (0 )    o
                    - Bad Back          (-1)    -

                    - Net Change        (0 )
            */

            // Stats
            Health      += 0;
            Strength    += 1;
            Speed       += 0;
            Magic       += 0;
            Luck        += 0;
            Agility     += -1;
            PlayerClass = Enums.PlayerType.Serf;

            // Derived Stats
            GenerateDerivedStuff();
        }
    }
}