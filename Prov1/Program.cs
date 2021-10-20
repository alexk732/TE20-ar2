using System;

namespace Prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduktion
            Console.WriteLine("Beräkna din nettolön");
            Console.WriteLine("----------------------");

            //Skriv ditt namn
            Console.Write("Skriv ditt namn: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string namn = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        
            //Ange din bruttolön
            Console.Write("Ange din bruttolön: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int bruttolön = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //Ange din skattesats
            Console.Write("Ange din skattesats i procent: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int skattesats = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //Nettolön beräkning
            Console.Write($"{namn}, din nettolön blir ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{bruttolön * (100 - skattesats) / 100} kr ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("baserat på bruttolönen ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{bruttolön} kr "); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("och skattesatsen ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{skattesats}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");

            //Vänta tills programmet stängs
            Console.ReadKey();
        }
    }
}
