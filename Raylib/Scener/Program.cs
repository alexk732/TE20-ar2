using System;
using Raylib_cs;

namespace Scener
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            const int fönsterB = 800;
            const int fönsterH = 450;

            Raylib.InitWindow(fönsterB, fönsterH, "raylib [cs]");
            Raylib.SetTargetFPS(60);

            // Gamestate-variabler
            float sek = 105;
            string scen = "Scen 0";
            //-------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Uppdatering
                //---------------------------
                // TODO: Uppdatera variabler här
                //---------------------------

                // Rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE); // Använde annan lösning

                if (scen == "Scen 0")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen, 10, 10, 50, Color.RED);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek}", 600, 0, 50, Color.RED);

                    // Räkna ner tiden kvar
                    sek -= Raylib.GetFrameTime();
                    if (sek <= 45)
                    {
                        scen = "Scen 1";
                    }
                }
                else if (scen == "Scen 1")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen, 10, 10, 50, Color.RED);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek}", 600, 0, 50, Color.RED);

                    // Räkna ner tiden kvar
                    sek -= Raylib.GetFrameTime();
                    if (sek <= 0)
                    {
                        scen = "Slut";
                    }
                }
                else if (scen == "Slut")
                {
                    Raylib.DrawText("Game Over!", 200, 200, 50, Color.RED);
                }

                Raylib.EndDrawing();
                //--------------------------------------------------------
            }
        }
    }
}
