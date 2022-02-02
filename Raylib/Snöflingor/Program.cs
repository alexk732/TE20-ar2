using System;
using Raylib_cs;

namespace Snöflingor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // Skapa en snöflinga
            Random generator = new Random();

            // Array för många snöflingor
            Rectangle[] flingor = new Rectangle[100];

            // Array for snöflingarnas hastighet
            int[] hastighet = new int[100];

            // Loopa igenom arrayen och fyll med snöflingor
            for (var i = 0; i < flingor.Length; i++)
            {
                // Slumpa snöflingornas storlekar
                int storlek = generator.Next(5, 16);

                flingor[i] = new Rectangle(0, 0, storlek, storlek);
                flingor[i].x = generator.Next(0, fönsterB);
                flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
            }

            // Loopa igenom arrayen och fyll i snöflingornas hastighet
            for (var i = 0; i < flingor.Length; i++)
            {
                hastighet[i] = generator.Next(1, 6);
            }

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                for (var i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y += hastighet[i];
                    if (flingor[i].y > fönsterH)
                    {
                        flingor[i].y = -15;
                    }
                }

                // Rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                for (var i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                }

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
