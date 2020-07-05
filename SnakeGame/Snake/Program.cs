using Snake.Game;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            double frameRate = 1000 / 5.0;

            IGame game = new Game.Game(frameRate);

            game.Update();
        }
    }
}

