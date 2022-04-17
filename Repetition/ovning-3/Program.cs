using System;

namespace ovning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Använda metod 1
            Print32();

            // Använda metod 2
            PrintText32("Hej världen!");

            // Använda metod 3
            Console.Write("Matat in ett tal 5-10: ");
            string stringTal = Console.ReadLine();
            int tal = LäsInHeltal(stringTal);

            // Använda metod 3 igen
            Console.Write("Matat in ett tal 50-100: ");
            int tal2 = LäsInHeltal(Console.ReadLine()); 
        }

        // Skapa en metod som, när den anropas, skriver ut "Hello World!" 32 gånger.
        static void Print32()
        {
            string texten = "Hello World!";
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine(texten);
            }
        }

        static void PrintText32(string texten)
        {
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine(texten);
            }
        }

        static int LäsInHeltal(string stringTal)
        {
            int tal = 0;
            while (!int.TryParse(stringTal, out tal))
            {
                Console.Write("Du måste mata in ett heltal. Försök igen: ");
                stringTal = Console.ReadLine();
            }
            return tal;
        }
    }
}
