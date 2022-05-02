using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in din e-post: ");
            string epost = Console.ReadLine();

            // Kolla att texten innehåller @
            if (epost.Contains("@"))
            {
                Console.WriteLine("Det verkar som du har skrivit in en korrekt e-postadress");
            }

            // 1 + 2 + 3, 2 * 6, 10 / 3
            Console.WriteLine("Mata in ett mattetal: ");
            string mattetal = Console.ReadLine();
            
            // Berätta om: +, -, *, eller / har använts
            if (mattetal.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
            }
        }
    }
}
