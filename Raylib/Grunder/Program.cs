using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej Raylib!");

            // Starta ett fönster
            Raylib.InitWindow(800, 600, "Ett Raylib-fönster");

            // Ställ in FPS
            Raylib.SetTargetFPS(60);

            // Animationsloppen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Tömma ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita en fyrkant
                Raylib.DrawRectangle(100, 100, 110, 100, Color.BLUE);
                Raylib.DrawRectangle(50, 100, 32, 20, Color.GOLD);

                // Rita en cirkel
                Raylib.DrawCircle(400, 400, 10, Color.RED);

                // Rita text
                Raylib.DrawText("Sample Text", 100, 500, 50, Color.DARKGREEN);

                // Sluta rita
                Raylib.EndDrawing();
            }

        }
    }
}
