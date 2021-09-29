using System;

namespace Choose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Välkommen till \"Välj ditt äventyr\" Press any key to begin.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You're walking in the woods at night when the road suddenly splits in two. Write \"right\" or \"");

            string direction = Console.ReadLine();
            


            //Wait until closed
            Console.ReadKey();
        }
    }
}
