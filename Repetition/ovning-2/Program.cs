using System;

namespace ovning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en string-array med namnen på fem olika leksaker.
            string[] leksaker = {"lego", "furby", "boll", "playmobil", "tamagotchi"};

            // Skriv ut innehållet i arrayen
            // Alternativ 1
            for (var i = 0; i < leksaker.Length; i++)
            {
                Console.Write(leksaker[i]);        // leksaker[0] = "lego"
            }

            // Alternativ 2
            foreach (var leksak in leksaker)
            {
                Console.WriteLine(leksak);
            }
        }
    }
}
