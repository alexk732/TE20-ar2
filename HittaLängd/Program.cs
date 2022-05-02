using System;

namespace HittaLängd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren mata in 3 kompisar
            string[] kompisar = new string[3];
            for (int i = 0; i < kompisar.Length; i++)
            {
                Console.Write("Vad heter en kompis?: ");
                string kompisen = Console.ReadLine();
                kompisar[i] = kompisen;
            }

            // Efter inmatning
            // Skriv ut längden på varje kompis namn
            foreach (var kompis in kompisar)
            {
                Console.WriteLine($"{kompis} är {kompis.Length} lång.");
            }

            // Avsluta med
            // Skriv också ut vem som har längst namn

        }
    }
}
