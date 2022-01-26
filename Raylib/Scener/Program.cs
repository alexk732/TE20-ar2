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

            Raylib.InitWindow(fönsterB, fönsterH, "Jaga alien");
            Raylib.SetTargetFPS(60);

            Random generator = new Random();

            // Gamestate-variabler
            int poäng = 0;
            int hastighet = 5;
            float sek = 105;
            string scen = "Scen 0";

            // Ladda in bilder
            Texture2D alienBild = Raylib.LoadTexture(@"./resurser/monster.png");
            Texture2D spelareBild = Raylib.LoadTexture(@"./resurser/satellite.png");

            // Ändra storlek på bilderna
            spelareBild.height = 80;
            spelareBild.width = 80;
            alienBild.height = 80;
            alienBild.width = 80;

            // Skapa en spelare och en alien
            Rectangle spelare = new Rectangle(generator.Next(1, 200), generator.Next(1, 450), spelareBild.width, spelareBild.height);
            Rectangle alien = new Rectangle(generator.Next(300, 750), generator.Next(1, 450), alienBild.width, alienBild.height);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Uppdatering
                //---------------------------
                // Kolla om spelare träffar alien
                if (Raylib.CheckCollisionRecs(spelare, alien))
                {
                    // Slumpa fram en ny position
                    alien.x = generator.Next(1, 750);
                    alien.y = generator.Next(1, 450);
                    poäng++;
                }

                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += hastighet;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= hastighet;
                }

                // Rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                // Rita ut objekten
                Raylib.DrawTexture(alienBild, (int)alien.x, (int)alien.y, Color.WHITE);
                Raylib.DrawTexture(spelareBild, (int)spelare.x, (int)spelare.y, Color.WHITE);

                Raylib.DrawText($"Poäng {poäng}", 10, 60, 50, Color.ORANGE);

                if (scen == "Scen 0")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen, 10,10, 50, Color.RED);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek}", 600, 10, 50, Color.RED);

                    // Räkna ner tiden kvar
                    sek -= Raylib.GetFrameTime();
                    if (sek <= 45)
                    {
                        scen = "Scen 1";
                    }
                }
                else if (scen == "Scen 1")
                {
                    // Bestäm hastigheten
                    hastighet = 10;

                    // Rita bakgrunden
                    Raylib.ClearBackground(Color.BLACK);

                    // Rita spelaren
                    Raylib.DrawTexture(spelareBild, (int)spelare.x, (int)spelare.y, Color.RED);
                    
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
                    // Påbörja slutskärmen
                    Raylib.BeginDrawing();
                    Raylib.DrawText("Game Over!", 200, 200, 50, Color.RED);
                    Raylib.DrawText($"Poäng {poäng}", 10, 60, 50, Color.ORANGE);
                }
                
                Raylib.EndDrawing();
                //--------------------------------------------------------
            }
        }
    }
}
