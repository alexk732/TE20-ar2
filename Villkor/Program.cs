using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren om ålder
            Console.Write("Hur gammal är du? (heltal): ");
            int age = int.Parse(Console.ReadLine());

            // Om ålder är större än 18 så får du ta körkort.
            if (age >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }
            // Om ålder är 15 eller högre så får du ta mopedkörkort.
               if (age >= 15)
            {
                Console.WriteLine("Du får ta mopedkörkort!");
            }
            // Fråga användaren "Vad heter ABBAs senaste album?"
            Console.WriteLine("Vad heter ABBAs senaste album? ");
            string album = Console.ReadLine();

            // Är svaret korrekt?
            if (album == "Voyage" || album == "voyage")
            {
                Console.WriteLine("Bra svarat!");
            }
            else
            {
                Console.WriteLine("Fel! Albumet heter \"Voyage!\"");

            //Sista frågan
            Console.Write("Vem missade straffen i matchen England-Frankrike? (efternamn) ");
          

            //läs in och tvinga till små bokstäver:
            //Mbappe -> mbappe
            //mBappe -> mbappe
            string player = Console.ReadLine().ToLower();
            player = Console.ReadLine();

            if (player == "mbappe")
            {
                Console.WriteLine("Bra, du är en expert!");
            }
            
            }
            //vänta tills fönstret stängs
            Console.ReadKey();
        }
    }
}
