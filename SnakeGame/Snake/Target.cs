using System;

namespace Snake
{
    class Target : ITarget
    {

        private Coords _coordinates;

        public Target()
        {
            SetNewPosition();
        }

        public void Draw()
        {
            Console.SetCursorPosition(_coordinates.X, _coordinates.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
        }

        public Coords Position() => _coordinates;

        public void SetNewPosition()
        {
            Random random = new Random();
            var playgroundWidht = Console.WindowWidth;
            var playgroundHeight = Console.WindowHeight;


            _coordinates = new Coords(random.Next(1, playgroundWidht), random.Next(1, playgroundHeight));
        }
    }
}
