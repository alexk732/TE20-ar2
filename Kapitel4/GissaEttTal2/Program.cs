using System;

namespace GissaEttTal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spelet \"Gissa ett tal!\"");
            
            //Spela flera gånger
            while (true)
            {
                //Slumpa fram ett tal
                Random tärning = new Random();
                int slumptal = tärning.Next(1, 51);
                
                //Upprepa frågan 5 gånger
                int räknare = 0;
                while (true)
                {
                    //Räkna upp antal gissningar
                    räknare++;

                    //Fråga användaren om en gissning
                    Console.WriteLine("Gissa ett tal (1-50):");
                    int gissning = int.Parse(Console.ReadLine());

                    //Är gissningen rätt?
                    if (gissning == slumptal)
                    {
                        Console.WriteLine($"Bra gissat! Du klarade det på {räknare} försök.");
                        Console.ReadKey();
                        break;
                    }

                    //Bryt efter 5 varv
                    if (räknare >= 5)
                    {
                        break;
                    }

                    //Jämför med slumptal
                    if (gissning < slumptal)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.WriteLine("För högt!");
                    }
                }
                Console.WriteLine("Slut på försök! Börja om."); 
            }
        }
    }
}
