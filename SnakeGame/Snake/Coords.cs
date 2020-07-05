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
    }
}
