using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string age = Console.ReadLine();

            Console.WriteLine($"Du är {age} gammal.");

            //Konvertera från string till heltal
            int ageNumber = int.Parse(age);

            Console.WriteLine($"Det är {20 - ageNumber} år kvar tills du får gå på systembolaget.");

            Console.Write("Hur mycket väger du?");
            float weight = float.Parse(Console.ReadLine());

            Console.WriteLine($"Din vikt blir {weight} * 2.2 kg");
            
    
        }
    }
}
