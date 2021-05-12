using Raylib_cs;
using System;

namespace troll
{
    public static class Map
    {

        static Texture2D lol = Raylib.LoadTexture("firstScene.png");



        public static void DrawMap()
        {
            //själva banan
            Raylib.DrawTexture(lol, 0, 0, Color.WHITE);

        }
    }
}
