using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {

            // Slumpgenerator
            Random generator = new Random();

            // Slumpa fram ett tal 1-10
            int slumptal = generator.Next(1, 11);

            // Skapa ett program som ska fungera som ett lyckohjul
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------");
            Console.WriteLine("Välkommen till Lyckohjulet! \nDet kommer att slumpa ut ett tal mellan 1 och 10."); 
            Console.WriteLine("Om du gissar rätt så får du ingenting! \nDu har 3 försök på dig. \n----------------------");

            // När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
            bool vann = false;
            
            for (int i = 1; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Välj ett tal mellan 1 och 10: "); 
                Console.ForegroundColor = ConsoleColor.Yellow;
                int usertal = int.Parse(Console.ReadLine());

                if (usertal == slumptal)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Du gissade rätt!");
                    vann = true;
                    Console.ReadKey();
                    
                }

                if (i < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel! Gissa igen.");
                    vann = false;
                }
            }

            // Berätta också för användaren om hen vann eller förlorade
            if (vann == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Du förlorade! Det rätta talet var ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{slumptal}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(".");
                Console.ReadKey();
            }
        }
    }
}
