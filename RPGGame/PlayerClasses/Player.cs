using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RPGGame
{
    public abstract class Player
    {
        // General
        public string       name;
        public int          playerId;
        public int          armourRating;
        public PlayerClass  playerClass = PlayerClass.AverageJoe;
        
        // Stats 
        public int          health      = 100;
        public int          speed       = 10;
        public int          magic       = 0;
        public int          luck        = 10;
        public int          agility     = 10;

        // Constructor
        protected Player(string aName = "MISSING_NAME")
        {
            name = aName;
        }

        public void DeclareOneself()
        {
            Console.WriteLine($"I AM A {playerClass}!".ToUpper());
        }
        
    }
}