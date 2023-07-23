using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using cs_rpg_game.Enums;
using cs_rpg_game.PeopleClasses;
using RPGGame.Enums;


namespace RPGGame.PlayerClasses
{
    public abstract class Player : PeopleBase
    {
        // General
        public PlayerType   PlayerClass     {get;set;}  = PlayerType.Serf;
        static public int   PlayerId        {get;set;}  = 0;
        
        // Constructor
        protected Player(string aName = "MISSING_NAME")
        {
            // Personal Stuff
            Name    = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                aName.ToLower()
            );
            
            // Backpack generation
            double invSizeMod   = Math.Floor(INV_STR_MOD * Strength);
            InvSize             = BASE_INV_SIZE + (int)invSizeMod;
            Backpack            = new string[InvSize];
        }
        
        // Actions
        public void DeclareOneself()
        {
            Console.WriteLine($"I AM A {PlayerClass}!".ToUpper());
        }

        // Information Declarations
        public void WhatIsBackpackSize()
        {
            Console.WriteLine($"Current backpack size: {InvSize}");
        }

        public void WhatIsName()
        {
            Console.WriteLine($"My name is {Name}");
        }
        
        public void WhatIsBackpackContents()
        {
            Console.WriteLine("[{0}]", string.Join(", ", Backpack));
        }
    }
}