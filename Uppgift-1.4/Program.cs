using System;

namespace Uppgift_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Uppgift 1.4";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WindowHeight = 30;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("testmeddelande");

            //wait before closing
            Console.ReadKey();
        }
    }
}
