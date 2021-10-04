using System;

namespace Choose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to \"Choose your adventure!\" Press any key to begin.");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You're lost and walking in the woods at night when the road suddenly splits in two. Do you go right or left? (r/l): ");

            string direction = Console.ReadLine();
            if (direction == "r")
            {
                Console.Write("You go to the right. After walking for a while longer, you reach a scary shack. Go inside or around? (i/a): ");
                string insideAround = Console.ReadLine();
                if (insideAround == "a")
                {
                    Console.Write("You go around the shack. Behind it, there's a murderer with an axe. Do you say hello or run? (h/r): ");
                    string helloRun = Console.ReadLine();
                    if (helloRun == "h")
                    {
                        Console.Write("You decide to say hello to the murderer. He is friendly and polite, so he greets you back and shows you the way out of the forest. ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You Win!");
                    }
                    else if (helloRun == "r")
                    {
                        Console.Write("You decide to run away from the murderer. He throws his axe at you and kills you. ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Game Over.");
                    }
                }
                else if (insideAround == "i")
                {
                    Console.Write("Inside the shack, there's a dead body and a hatch in the floor. Check out the dead body or the hatch? (d/h): ");
                    string bodyHatch = Console.ReadLine();
                    if (bodyHatch == "h")
                    {
                        Console.Write("You approach the hatch in the floor and open it. Inside, there's a secret passage that leads you out of the forest.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You Win!");
                    }
                    else if (bodyHatch == "d")
                    {
                        Console.Write("When you approach the dead body to check it out, a murderer with an axe opens the front door of the shack and notices you. You want to flee somehow, but the odor from the body makes you unable to think clearly. The murderer kills you. ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Game Over.");
                    }
                }
            }
            else if (direction == "l")
            {
                Console.Write("You go to the left. After a minute of walking, you reach a swamp. Do you try to find another way around it? (y/n): ");
                string goAround = Console.ReadLine();
                if (goAround == "y")
                {
                    Console.Write("When you try to find a way around the swamp, you slip on the wet grass, hit your head and drown in the water. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Game Over.");
                }
                else if (goAround == "n")
                {
                    Console.Write("You take a few steps forward and quickly start to sink down in the swamp. Do you want to try to swim? (y/n): ");
                    string swim = Console.ReadLine();
                    if (swim == "y")
                    {
                        Console.Write("You start to swim, and the water is actually quite easy to get through. After some effort, you reach dry land again. You go through a passage between big trees and find yourself outside the forest. ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("You Win!");
                    }
                    else if (swim == "n")
                    {
                        Console.Write("You decide not to swim. Your head gets under the water, and you can't breathe. Instead, you drown. ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Game Over.");
                    }
                }
            }

            //Wait until closed
            Console.ReadKey();
        }
    }
}
