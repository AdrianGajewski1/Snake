using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    interface ISnake : IGameObject
    {
        void Move(Direction direction);
        void Eat();
        bool GameOver();
        bool IsOverlapping(IGameObject gameObject);
    }
}
