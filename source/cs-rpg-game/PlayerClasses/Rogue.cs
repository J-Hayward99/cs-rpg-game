using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGGame.PlayerClasses
{
    public class Rogue : Player
    {
        public Rogue(string aName) : base(aName)
        {
            /*
                Gist:
                    - Okay              (-1)    -
                    - Weak              (-4)    -
                    - Fast              (+2)    +
                    - Default Magic     (+0)    o
                    - Lucky             (+1)    +
                    - Very Agile        (+2)    +

                    - Net Change        (0 )
            */

            // Stats 
            Health      += -1;
            Strength    += -4;
            Speed       += 2;
            Magic       += 0;
            Luck        += 1;
            Agility     += 2;
            PlayerClass = Enums.PlayerType.Rogue;
            AddStorage  = cs_rpg_game.Enums.StorageType.Sack;
            
            // Derived Stats
            GenerateDerivedStuff();
        }
    }
}