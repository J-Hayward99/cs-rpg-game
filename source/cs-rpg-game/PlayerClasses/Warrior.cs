using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.PlayerClasses
{
    public class Warrior : Player
    {
        public Warrior(string aName) : base(aName)
        {   
            /*
                Gist:
                    - Tank              (+2)    +
                    - Strong            (+2)    +
                    - Slow              (-2)    -
                    - Default Magic     (+0)    o
                    - Default Luck      (+0)    o
                    - Not Agile         (-2)    -

                    - Net Change        (0 )
            */

            // Stats 
            Health      += 2;
            Strength    += 2;
            Speed       += -2;
            Magic       += 0;
            Luck        += 0;
            Agility     += -2;
            PlayerClass = Enums.PlayerType.Warrior;
            
            // Derived Stats
            GenerateDerivedStuff();
        }
    }
}