﻿using System;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number between 1 and 5: ");

            int number = Convert.ToInt32(Console.ReadLine());

            switch (number) {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            //wait before closing
            Console.ReadKey();
        }
    }
}
