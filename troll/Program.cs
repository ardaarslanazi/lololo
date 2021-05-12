using System;
using Raylib_cs;
using fiskmove;
using fightboss;

namespace troll
{
    static class Program
    {


        static void Main(string[] args)
        {

            string scene = "first";
            Raylib.InitWindow(1240, 720, "Scene");

            Movements.Init();

            Texture2D lol = Raylib.LoadTexture("firstScene.png");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                //första scenen 
                if (scene == "first")
                {

                    Raylib.ClearBackground(Color.WHITE);
                    Map.DrawMap();
                    Movements.Movement();

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        scene = "boss fight";
                    }
                }
                //Nästa scen med boss fight
                if (scene == "boss fight")
                {
                    Raylib.ClearBackground(Color.WHITE);
                    boss.FightMap();
                    Movements.Movement();

                }
                Raylib.EndDrawing();

            }



        }
    }
}
