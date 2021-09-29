using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Change the appearance

            Console.Title = "window";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 40;

            //get a conversation going
            
            Console.WriteLine("Hello, what's your name?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine(); // This also works

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My name is RX-9000.\nI am an AI sent from the future to destroy mankind.");
            Console.WriteLine("What is your favorite color?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cool! Mine is destruction.");

            Console.ReadKey();
        }
    }
}
