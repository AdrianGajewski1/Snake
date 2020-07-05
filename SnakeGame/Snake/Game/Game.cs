using System;

namespace Snake.Game
{
    public class Game : IGame
    {
        private bool _gameOver = false;

        private double _frameRate;

        private DateTime _lastDate = DateTime.Now;

        private ISnake snake = new Snake();

        private ITarget target = new Target();

        public Game(double frameRate)
        {
            _frameRate = frameRate;
        }

        public void Update()
        {
            while(_gameOver == false)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                }

                if((DateTime.Now - _lastDate).TotalMilliseconds >= _frameRate)
                {
                    snake.Draw();
                    target.Draw();

                    _lastDate = DateTime.Now;
                }
                 
            }
        }
    }
}
