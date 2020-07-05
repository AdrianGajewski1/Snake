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

        private Direction snakeDirection = Direction.Right;
        public Game(double frameRate)
        {
            _frameRate = frameRate;
        }
        public void Update()
        {
            while(_gameOver == false)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch (input.Key)
                    {
                        case ConsoleKey.UpArrow:
                            snakeDirection = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            snakeDirection = Direction.Down;
                            break;
                        case ConsoleKey.LeftArrow:
                            snakeDirection = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snakeDirection = Direction.Right;
                            break;
                    }
                }

                if((DateTime.Now - _lastDate).TotalMilliseconds >= _frameRate)
                {
                    snake.Draw();
                    snake.Move(snakeDirection);
                    
                    target.Draw();

                    if (snake.IsOverlapping(target))
                    {
                        snake.Eat();
                        target.SetNewPosition();
                    }

                    if (snake.GameOver() || snake.HitBorder())
                        _gameOver = true;


                    _lastDate = DateTime.Now;
                }
                 
            }

            if(_gameOver == true)
            {
                Console.Clear();
                Console.WriteLine($"Game Over, Score: {snake.GetLength()}");
            }
        }
    }
}
