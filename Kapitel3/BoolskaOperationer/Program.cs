using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coronasymptom");

            Console.Write("Har du feber? (ja/nej) ");
            string feber = Console.ReadLine();

            Console.Write("Hostar du? (ja/nej) ");
            string hosta = Console.ReadLine();

            Console.Write("Har du tappat smaken? (ja/nej) ");
            string smak = Console.ReadLine();

            Console.Write("Är du vaccinerad mot covid? (ja/nej) ");
            string covid = Console.ReadLine();

            // Om dessa tre villkor är uppfyllda
            if (feber == "ja" && hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            if (hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            if (feber == "ja" || hosta == "ja" && smak == "ja")
            {
                Console.WriteLine("Du har troligen Covid-19");
            }
            
            Console.ReadKey();
        }
    }
}
