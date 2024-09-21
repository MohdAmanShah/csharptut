struct Point
{
    public int X, Y;
    public Point() { }
    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void PrintPositions()
    {
        Console.WriteLine("{0}, {1}", X, Y);
    }
}
