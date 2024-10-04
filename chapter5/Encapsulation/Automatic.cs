using System.ComponentModel;

class Point
{
    public int x;
    public int y;
}

class Point2
{
    private int x;
    private int y;
}

class Point3
{
    public int X { get; set; }
    public int Y { get; set; }
}
class Point4
{
    public int X { get; }
    public int Y { get; }
}

class Point5
{
    private int X { get; set; }
    private int Y { get; set; }
    public Point5() { }
    public Point5(int x, int y)
    {
        this.X = X;
        this.Y = Y;
    }
}

class Point6
{
    public int X { get; init; }
    public int Y { get; init; }
    public PointColor Color { get; init; }
    public Point6() { Console.WriteLine("implicit calling"); }
    public Point6(PointColor color)
    {
        Color = color;
        Console.WriteLine("Third constructor was called.");
    }
    public Point6(int x, int y)
    {
        X = x;
        Y = y;
        Console.WriteLine("Constructor two was called.");
    }
}


enum PointColor
{
    Red,
    Green,
    Blue,
    Gold,
    Silver
}