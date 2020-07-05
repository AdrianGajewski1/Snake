using System;

namespace Snake
{
    public class Snake : ISnake
    {
        private int _speed;

        private ConsoleColor _color;

        private Coords _coordinates = new Coords();

        public Snake() : this(5) { }

        public Snake(int speed) : this(5, ConsoleColor.Green) { }

        public Snake (int speed, ConsoleColor color)
        {
            _speed = speed;
            _color = color;
        }


        public void Draw()
        {
            Console.SetCursorPosition(_coordinates.X, _coordinates.Y);
            Console.ForegroundColor = _color;
            Console.Write("#");
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public bool GameOver()
        {
            throw new NotImplementedException();
        }

        public bool IsOverlapping(IGameObject gameObject)
        {
            throw new NotImplementedException();
        }

        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public Coords Position() => _coordinates;
         
    }
}
