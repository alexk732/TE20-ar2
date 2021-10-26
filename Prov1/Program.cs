using System;

namespace Prov1 {
    class Program {
        static void Main(string[] args) {
            //Introduktion
            Console.WriteLine("Beräkna din nettolön");
            Console.WriteLine("----------------------");

            //Skriv ditt namn
            Console.Write("Skriv ditt namn: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string namn = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Ange din bruttolön
            Console.Write("Ange din bruttolön (mellan - - - kronor): ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int bruttolön = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            if (bruttolön <= -- || bruttolön >= -- ) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Din bruttolön måste vara mellan - och - kronor!");
            } 
            else
            {
                //Ange din skattesats
                Console.Write("Ange din skattesats i procent (mellan -- och -- procent): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int skattesats = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                if (skattesats <= -- || skattesats >= -- ) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Din skattesats måste vara mellan - och - kronor!");
                } 
                else
                {
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
                }
            }
            //Vänta tills programmet stängs
            Console.ReadKey();
        }
    }
}