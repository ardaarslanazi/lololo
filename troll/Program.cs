using System;
using Raylib_cs;
using ArdasHåla;
using fiskmove;
namespace troll
{
    class Program
    {

        static void Main(string[] args)
        {
            string scene = "first";
            Raylib.InitWindow(1240, 720, "Scene");
            Raylib.SetTargetFPS(60);
            Map.Init();
            Movements.Init();
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Console.ReadLine();
                if (scene == "first")
                {
                    Raylib.ClearBackground(Color.WHITE);
                    Map.DrawMap();
                    

    
                }
                Movements.Movement();
                Raylib.EndDrawing();
            }


        }
    }
}
