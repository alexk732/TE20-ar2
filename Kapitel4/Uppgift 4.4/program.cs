using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna 40 till 80");

            for (int i = 40; i < 81; i++)
            {
                Console.WriteLine($"Loop nr {i}");
            }
        }
    }
}
