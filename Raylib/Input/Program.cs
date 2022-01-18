using System;
using Raylib_cs;

namespace Bilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Starta grafikmotorn
            Raylib.InitWindow(800, 800, "Mitt Fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            // Skapa en spelare av en rektangel
            Rectangle spelare = new Rectangle(100, 100, 50, 50);
            // Ladda in bild för spelaren
            Texture2D moon = Raylib.LoadTexture(@"./resurser/moon.png");

            // Skapa en fiende av en rektangel
            Rectangle fiende = new Rectangle(100, 100, 50, 50);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                /* Rita ut grafiken */
                // Börja rita
                Raylib.BeginDrawing();
                
                // Töm ritytan
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut spelaren
                Raylib.DrawTexture(moon, (int)spelare.x, (int)spelare.y, Color.RED);

                // Rita ut fiende
                Raylib.DrawTexture(moon, (int)fiende.x, (int)fiende.y, Color.BLUE);

                // Ritat ut på fönstret
                Raylib.EndDrawing();

                /* Interaktion med användaren */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    spelare.y += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    spelare.y -= 5;
                }

                /* Interaktion med användare 2 */
                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    fiende.x += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    fiende.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    fiende.y += 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    fiende.y -= 5;
                }
            }
        }
    }
}
