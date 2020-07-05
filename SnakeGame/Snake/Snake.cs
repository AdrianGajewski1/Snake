using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake : ISnake
    {
        private int _speed;

        private ConsoleColor _color;

        private Coords _coordinates = new Coords();

        private int _length = 1;

        private IList<Coords> _body = new List<Coords>();

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

            _body.Add(new Coords(_coordinates.X, _coordinates.Y));

            if(_body.Count > _length)
            {
                var end = _body.First();
                Console.SetCursorPosition(end.X, end.Y);
                Console.Write(" ");
                _body.Remove(end);
            }
        }

        public void Eat()
        {
            _length++;
        }

        public bool GameOver() => _body.Any(c => c == _coordinates);
        

        public int GetLength() => _length;

        public bool HitBorder()
        {

            var playgroundWidht = Console.WindowWidth;
            var playgroundHeight = Console.WindowHeight;

            var hitX = _coordinates.X < 0 || _coordinates.X > playgroundWidht;
            var hitY = _coordinates.Y < 0 || _coordinates.Y > playgroundHeight;

            if (hitX == true)
                return true;
            else if (hitY == true)
                return true;
            else
                return false;
        }

        public bool IsOverlapping(IGameObject gameObject)
        {
            return _coordinates == gameObject.Position();
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    _coordinates.Y--;
                    break;
                case Direction.Down:
                    _coordinates.Y++;
                    break;
                case Direction.Left:
                    _coordinates.X--;
                    break;
                case Direction.Right:
                    _coordinates.X++;
                    break;
            }

        }

        public Coords Position() => _coordinates;
         
    }
}
