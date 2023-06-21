using RPGGame.PlayerClasses;

namespace RPGGame
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("==== MY TEST RPG ====");
            Console.WriteLine("By James Hayward\n");

            Warrior james = new("james");
            james.DeclareOneself();
        }
    } 
}