namespace Snake
{
    public class Coords
    {
        public Coords() : this(0, 0) { }

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator !=(Coords lhs, Coords rhs)
        {
            return (lhs.X != rhs.X && lhs.Y != rhs.Y);
        }

        public static bool operator ==(Coords lhs, Coords rhs)
        {
            return (lhs.X == rhs.X && lhs.Y == rhs.Y);

        }
    }
}
