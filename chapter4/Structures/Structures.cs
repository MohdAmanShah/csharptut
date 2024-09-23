public partial class Program
{
    private static void Runner()
    {
        // Point p1 = new Point();
        // p1.X = 23;
        // p1.Display();

        // Point p2;
        // p2.X = 10;
        // p2.Y = 15;
        // p2.Display();
        // Point p1 = new Point();
        // p1.Display();
        // Point p3 = new Point(12, 32);
        // p3.Display();
        // Point2 p1 = new Point2();
        // p1.Display();
    }
}

public struct Point
{
    private int _x;
    private int _y;
    public int X { get { return _x; } set { _x = value; } }
    public int Y { get { return _y; } set { _y = value; } }
    public Point(int x, int y)
    {
        this._x = x;
        this._y = y;
    }
    public Point() { }
    public void Display()
    {
        Console.WriteLine("({0}:{1})", X, Y);
    }
}

public struct Point2
{
    public int X { get; }
    public int Y { get; }
    public Point2()
    {
        X = 20;
        Y = 20;
    }
    public Point2(int x, int y)
    {
        X = X;
        Y = y;
    }
    public void Display()
    {
        Console.WriteLine("{0}:{1}", X, Y);
    }
}

