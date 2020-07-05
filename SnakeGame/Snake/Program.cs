using Snake.Game;
using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            double frameRate = 1000 / 8;

            IGame game = new Game.Game(frameRate);

            game.Update();
        }
    }
}

