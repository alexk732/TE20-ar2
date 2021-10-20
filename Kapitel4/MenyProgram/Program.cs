using System;

namespace MenyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt menyprogram!");

            // Skapa en slumpgenerator
            Random tärning = new Random();

            // Programloopen
            while(true)
            {
                // Slumpa fram ett tal
                int slumptal = tärning.Next(1, 4);

                Console.WriteLine("Välj ett av följande alternativ: ");
                Console.WriteLine("Väljer du sten? (1)");
                Console.WriteLine("Väljer du sax? (2)");
                Console.WriteLine("Väljer du påse? (3)");
                Console.WriteLine("Vill du avsluta? (4)");
                string valString = Console.ReadLine();
                
                // Vill användaren avsluta?
                if (valString == "4")
                {
                    break;
                }

                // Omvandla till en int eftersom slumptal är en int
                int val = int.Parse(valString);

                // Om 
                if (slumptal == "1" && valString == "1")
                {
                    Console.WriteLine("Lika!");
                }
                if (slumptal == "1" && valString == "2")
                {
                    Console.WriteLine("Du förlorar!");
                }
                if (slumptal == "1" && valString == "3")
                {
                    Console.WriteLine("Du vinner!");
                }

                if (slumptal == "2" && valString == "1")
                {
                    Console.WriteLine("Du vinner!");
                }
                if (slumptal == "2" && valString == "2")
                {
                    Console.WriteLine("Lika!");
                }
                if (slumptal == "2" && valString == "3")
                {
                    Console.WriteLine("Du förlorar!");
                }

                if (slumptal == "3" && valString == "1")
                {
                    Console.WriteLine("Du förlorar!");
                }
                if (slumptal == "3" && valString == "2")
                {
                    Console.WriteLine("Du vinner!");
                }
                if (slumptal == "3" && valString == "3")
                {
                    Console.WriteLine("Lika!");
                }
            }
        }
    }
}
