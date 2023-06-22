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
            // Stats 
            health      = 150;
            speed       = 8;
            magic       = 0;
            luck        = 10;
            agility     = 5;
            playerClass = Enums.PlayerType.Warrior;
        }
    }
}