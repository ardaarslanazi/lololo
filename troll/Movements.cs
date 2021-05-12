using Raylib_cs;
using System;
namespace fiskmove
{
    static class Movements
    {

        static int trollX = 500;
        static int trollY = 100;
        static Image trollface = Raylib.LoadImage("trollright.png");
        static Image trollleft = Raylib.LoadImage("trollleft.png");
        static Texture2D forward = Raylib.LoadTexture("forward.png");

        static Texture2D trollRight;
        static Texture2D Left;

        static string facing = "nowhere";

        public static void Init()
        {
            Raylib.ImageResizeNN(ref trollface, 200, 150);
            Raylib.ImageResizeNN(ref trollleft, 200, 170);
            trollRight = Raylib.LoadTextureFromImage(trollface);
            Left = Raylib.LoadTextureFromImage(trollleft);
        }
        public static void Movement()
        {   //om man står stilla
            Raylib.DrawTexture(forward, trollX, trollY, Color.WHITE);
            if (facing == "nowhere")
            {
                Raylib.DrawTexture(forward, trollX, trollY, Color.WHITE);
            }
            //rör åt höger
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {

                facing = "east";

                Raylib.DrawTexture(trollRight, trollX, trollY, Color.WHITE);

                trollX = trollX + 2;

                if (trollX >= 1240)

                {

                    trollX = 100;

                }

            }
            //rör åt vänster
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))

            {

                facing = "west";

                Raylib.DrawTexture(Left, trollX, trollY, Color.WHITE);

                trollX = trollX - 2;

            }
            // rör neråt
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))

            {
                facing = "south";

                trollY = trollY + 2;
            }
            //rör uppåt
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                facing = "north";

                trollY = trollY - 2;
            }
        }

    }
}