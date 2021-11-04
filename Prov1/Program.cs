using System;

namespace Prov1 {
    class Program {
        static void Main(string[] args) {

            for (var i = 1; i > 0; i++) 
            {
                // Introduktion
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------------");
                Console.WriteLine("Beräkna din nettolön");
                Console.WriteLine("----------------------");

                // Skriv ditt namn
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Skriv ditt namn: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string namn = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                // Ange din bruttolön
                Console.Write("Ange din bruttolön (mellan 10000 och 45000 kronor): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                int bruttolön = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;

                // Se ifall bruttolönen är godkänd
                if (bruttolön < 10000 || bruttolön > 45000) {
                    Console.WriteLine("----------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{namn}, din bruttolön måste vara mellan 10000 och 45000 kronor!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Försök igen.");
                    Console.ReadKey();
                    break;
                } 
                else 
                {
                    // Ange din skattesats
                    Console.Write("Ange din skattesats i procent (mellan 10 och 45 procent): ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    int skattesats = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    // Se ifall skattesaten är godkänd
                    if (skattesats < 10 || skattesats > 45) {
                        Console.WriteLine("----------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{namn}, din skattesats måste vara mellan 10 och 45 procent!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Försök igen.");
                        Console.ReadKey();
                        break;
                    } 
                    else 
                    {
                        // Nettolön beräkning
                        Console.WriteLine("----------------------");
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
                    // Fråga om användaren vill göra en ny beräkning
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nVill du göra en ny beräkning? Skriv \"ja\": ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string svar = Console.ReadLine();
                    if (svar != "ja")
                    {
                        break;
                    }
                }
            }
        }
    }
}