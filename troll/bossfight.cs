using Raylib_cs;
using System;
namespace fightboss
{
    public static class boss
    {

        static Texture2D lol2 = Raylib.LoadTexture("fight.png");
        static Texture2D clueless = Raylib.LoadTexture("clueless.png");
        static Random generator = new Random();


        static int velocity = 1;
        static int velocityY = 1;
        static int insektx = generator.Next(100, 1200);
        static int insekty = generator.Next(100, 700);

        // static int ClueHP = generator.Next(1, 100);

        static int[] ClueHP = new int[] { 1 };


        public static void FightMap()
        {
            // Andra banan
            Raylib.DrawTexture(lol2, 0, 0, Color.WHITE);
            Raylib.DrawTexture(clueless, insektx, insekty, Color.WHITE);
            String ClueHpBar = Convert.ToString(ClueHP);
            Raylib.DrawText(ClueHpBar, insektx, insekty - 50, 50, Color.WHITE);


            insektx += velocity;
            insekty += velocityY;


            //clueless rör på sig
            if (insektx > 1500)
            {
                velocity = velocity * -1;

                System.Console.WriteLine("Clueless!");
            }
            else if (insektx < 0)
            {
                velocity = velocity * -1;

                System.Console.WriteLine("Clueless!");
            }
            if (insekty > 1080)
            {
                velocityY = velocityY * -1;
            }
            if (insekty < 0)
            {
                velocityY = velocityY * -1;
            }
        }
    }
}