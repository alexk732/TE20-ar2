using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] platser = new string[4];
            string[] platser2 = {"", "", ""};

            // Vi ska fylla den tomma arrayen
            for (var i = 0; i < platser.Length; i++)
            {
                Console.Write("Ange en plats: ");
                string plats = Console.ReadLine();
                platser[i] = plats;
            }

            // Skriv ut platser-arrayens innehåll
            foreach (var plats in platser)
            {
                Console.WriteLine(plats);
            }

            // Skriv ut alla i med stora bokstäver
            foreach (var plats in platser)
            {
                Console.WriteLine(plats.ToUpper());
            }
        }
    }
}
