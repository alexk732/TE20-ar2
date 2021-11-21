using System;

namespace Question
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int answerCount = 5;

            while (answerCount > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("--------------------");
                Console.WriteLine("Vad heter Europas folkrikaste land?");
                Console.WriteLine($"Du har {answerCount} försök på dig att svara rätt.");
                Console.WriteLine("--------------------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ditt svar: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string answer = Console.ReadLine();

            
                if (answer == "Ryssland" || answer == "ryssland")
                {
                
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Rätt!");
                    Console.ReadKey(true);
                    break;
                    
                }
                else
                {  
                    answerCount = answerCount - 1; 
                
                    if (answerCount > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Fel! Försök igen.");
                        Console.ReadKey(true);
                        Console.Clear();
                        
                    }    
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Fel! Du har inga försök kvar.");
                        Console.ReadKey(true);
                    }               
                }             
            }     
        }
    }
}
