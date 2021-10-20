using System;

namespace Prover
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berätta vad programmet gör
            Console.WriteLine("Uträkning av nettolön\n---------------------");

            // Fråga efter namn
            Console.Write("Vad heter du?: ");
            string namn = Console.ReadLine();

            // Fråga efter bruttolön
            Console.Write("Ange din bruttolön i kronor: ");
            int bruttolön = int.Parse(Console.ReadLine());

            // Kolla att villkoren är uppfyllda
            if (bruttolön >= 10000 && bruttolön <= 45000)
            {
                // fråga efter skattesats
                Console.Write("Ange din skattesats i kronor: ");
                int skattesats = int.Parse(Console.ReadLine());

                //Kolla att villkoren är uppfyllda för skattesats
                if (skattesats >= 10 && skattesats <= 45)
                {
                    // Räkna ut nettolön
                    int nettolön = bruttolön * (100 - skattesats) / 100;
                    Console.WriteLine($"{namn}, din lön efter skatt är {nettolön}");
                }
            }
            else
            {
                Console.WriteLine("Skattesatsen måste vara mellan 10000 och 45000 kronor!");
            }

            // Vill du köra igen?
            Console.WriteLine("Vill du köra igen? (j/n): ");
            string svar = Console.ReadLine();
            if (svar |= "j") / (svar == "n")
        }
    }
}
