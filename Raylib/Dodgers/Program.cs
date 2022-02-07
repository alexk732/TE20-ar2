
using System;
using Raylib_cs;

namespace Dodgers
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

            // TODO: Infoga variabler och objekt här
            Random generator = new Random();
            Rectangle mynt = new Rectangle(generator.Next(0, 400), 0, 25, 25);
            Rectangle spelare = new Rectangle(350, fönsterH - 50, 100, 20);
            Rectangle fiende = new Rectangle(generator.Next(0, 400), 0, 40, 40);

            // Gamestate-variabler
            int poäng = 0;
            int liv = 5;
            int myntHastighet = 3;
            int fiendeHastighet = 6;
            float tid = 60;

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                mynt.y += myntHastighet;
                fiende.y += fiendeHastighet;
                
                // Räkna upp tiden
                tid -= Raylib.GetFrameTime();

                // Om tiden är en viss tid
                if (tid < 40)
                {
                    myntHastighet = 6;
                    fiendeHastighet = 9;
                }
                if (tid < 20)
                {
                    myntHastighet = 9;
                    fiendeHastighet = 12;
                }
                if (tid < 1)
                {
                    break;
                }
                if (liv < 1)
                {
                    break;
                }

                // Om myntet når golvet
                if (mynt.y > fönsterH)
                {
                    mynt.y = -25;
                    mynt.x = generator.Next(0, fönsterB);
                }

                // Om fienden når golvet
                if (fiende.y > fönsterH)
                {
                    fiende.y = -25;
                    fiende.x = generator.Next(0, fönsterB);
                }

                // Lyssna på tangenter
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    spelare.x -= 5;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    spelare.x += 5;
                }

                // Kolla om spelaren är utanför skärmen
                if (spelare.x < -100)
                {
                    spelare.x = 800;
                }
                if (spelare.x > 800)
                {
                    spelare.x = -100;
                }

                // Om spelaren träffar ett mynt
                if (Raylib.CheckCollisionRecs(spelare, mynt))
                {
                    mynt.y = 0;
                    poäng += 1;
                    mynt.x = generator.Next(0, fönsterB);
                }

                // Om spelaren träffar en fiende
                if (Raylib.CheckCollisionRecs(spelare, fiende))
                {
                    fiende.y = 0;
                    liv -= 1;
                    fiende.x = generator.Next(0, fönsterB);
                }

                // Rita
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText($"Tid: {(int)tid}", 10, 10, 25, Color.WHITE);
                Raylib.DrawText($"Poäng: {poäng}", 10, 40, 25, Color.BLUE);
                Raylib.DrawText($"Liv: {liv}", 10, 70, 25, Color.RED);

                Raylib.DrawRectangleRec(mynt, Color.GOLD);
                Raylib.DrawRectangleRec(spelare, Color.WHITE);
                Raylib.DrawRectangleRec(fiende, Color.RED);

                Raylib.EndDrawing();
            }
            
            /*
            Raylib.DrawText("Spelet är slut!", 400, 400, 25, Color.WHITE);
            if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
            {
                Raylib.EndDrawing();
            }*/
        }
    }
}