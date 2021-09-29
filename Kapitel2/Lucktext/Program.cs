using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du?");
            string name = Console.ReadLine();

            Console.Write("Hur många år är du?");
            string age = Console.ReadLine();

            Console.Write("Vad är din favoritfärg?");
            string color = Console.ReadLine();

            Console.WriteLine($"Ett rymdskepp som heter {name} åker med hastigheten {age} km/h mot en planet som är helt {color}.");

            //wait before closing
            Console.ReadKey();
        }
    }
}
