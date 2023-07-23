using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.PlayerClasses
{
    public class Wizard : Player
    {
        public Wizard(string aName) : base(aName)
        {
            /*
                Gist:
                    - Frail             (-2)    -
                    - Bookworm          (-2)    -
                    - Slow              (-1)    -
                    - Default Magic     (+4)    +
                    - Default Luck      (+2)    +
                    - Nerd              (-1)    -

                    - Net Change        (0 )
            */

            // Stats 
            Health      += -2;
            Strength    += -2;
            Speed       += -1;
            Magic       += 4;
            Luck        += 2;
            Agility     += -1;
            PlayerClass = Enums.PlayerType.Wizard;
            
            // Derived Stats
            GenerateDerivedStuff();
        }
    }
}