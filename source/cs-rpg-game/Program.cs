using RPGGame.PlayerClasses;

namespace RPGGame
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==== RPG GAME ====");
            Console.WriteLine("By James Hayward\n");

            Warrior james = new("james");
            james.WhatIsName();
            james.DeclareOneself();
            james.WhatIsBackpackSize();
            Console.WriteLine("");

            Archer archy = new("archy");
            archy.WhatIsName();
            archy.DeclareOneself();
            archy.WhatIsBackpackSize();
            Console.WriteLine("");

            Wizard harry = new("harry");
            harry.WhatIsName();
            harry.DeclareOneself();
            harry.WhatIsBackpackSize();
            Console.WriteLine("");

            Rogue garrett  = new("garrett");
            garrett.WhatIsName();
            garrett.DeclareOneself();
            garrett.WhatIsBackpackSize();
            Console.WriteLine("");

            Serf bill = new("bill");
            bill.WhatIsName();
            bill.DeclareOneself();
            bill.WhatIsBackpackSize();
            Console.WriteLine("");
        }
    } 
}