using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            Console.WriteLine("Program som skriver ut ASCII");

            // Be användaren mata in ett ord
            Console.Write("Ange ett ord: ");
            string ord = Console.ReadLine();

            Console.WriteLine("Ange en nyckel: ");
            int nyckel = int.Parse(Console.ReadLine());
            

            // Loopa igenom ordet bokstav-för-bokstav
            string krypteratMeddelande = "";
            for (int i = 0; i < ord.Length; i++)
            {
                // Plocka ut en bokstav
                char bokstav = ord[i];

                // Hitta koden för bokstaven
                int kod = (int)bokstav;

                // Lägg till nyckeln
                kod = kod + nyckel;   // kod += nyckel;

                // Vad är den nya bokstaven?
                char bokstavKrypterad = (char)(kod);

                // Console.WriteLine($"{bokstav} {kod} {bokstavKrypterad}");

                krypteratMeddelande += bokstavKrypterad.ToString();
            }

            // Skriv ut färdiga meddelandet
            Console.WriteLine(krypteratMeddelande);
        }
    }
}
