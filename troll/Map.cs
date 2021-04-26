using Raylib_cs;
using System;
namespace ArdasHåla
{
    static class Map
    {
        static Image lax = Raylib.LoadImage("lax.png");

        static Texture2D lol = Raylib.LoadTexture("firstScene.png");

        

        static float laxspeedx = 400;
        static float laxspeedy = 610;
        public static void Init()
        {
            Raylib.ImageResizeNN(ref lax, 200, 200);
        }
        static Texture2D laxen = Raylib.LoadTextureFromImage(lax);


        
        public static void DrawMap()
        {
            
            Console.ReadLine();
            Raylib.DrawTexture(lol, 0, 0, Color.WHITE);
            Raylib.DrawTexture(laxen, (int)laxspeedx, (int)laxspeedy, Color.WHITE);
            laxspeedx += 20.0f * Raylib.GetFrameTime();
            laxspeedy -= 10.0f * Raylib.GetFrameTime();
            if (laxspeedx == 200)
            {
                laxspeedx = 400;
                laxspeedy = 610;
            }
            if (laxspeedy == 200)
            {
                laxspeedy = 610;
                laxspeedx = 400;
            }
        }
    }
}
