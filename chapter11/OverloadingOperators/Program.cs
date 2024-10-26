public class Program
{
    public static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);
        Point p3 = p1 + p2;
        Point p4 = 5 + p3;
        Point p5 = p4 + 5;
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        Console.WriteLine(p4);
        Console.WriteLine(p5);
        Console.WriteLine(p1 - p5);
        p3 += p4;
        Console.WriteLine("p3: {0}", p3);
        Console.WriteLine("p3++: {0}", p3++);
        Console.WriteLine("p3: {0}", p3);
        Console.WriteLine("++p3: {0}", ++p3);
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1 < p2);
        Console.WriteLine(p1 <= p2);
    }
}

class Point : IComparable<Point>
{
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"[{X}, {Y}]";
    }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }
    public static Point operator +(Point p1, int change)
    {
        return new Point(p1.X + change, p1.Y + change);
    }
    public static Point operator +(int change, Point p)
    {
        return p + change;
    }
    public static Point operator ++(Point p)
    {
        return new Point(p.X + 1, p.Y + 1);
    }
    public override bool Equals(object? obj)
    {
        return this.ToString() == obj?.ToString();
    }
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public int CompareTo(Point? other)
    {
        if (other is null) return 1;
        double disp1 = Math.Sqrt(Math.Pow((double)X, 2.0) + Math.Pow((double)Y, 2.0));
        double disp2 = Math.Sqrt(Math.Pow((double)other.X, 2.0) + Math.Pow((double)other.Y, 2.0));
        if (disp1 > disp2) return 1;
        else if (disp1 == disp2) return 0;
        return -1;
    }

    public static bool operator ==(Point p1, Point p2)
    {
        return (p1.X == p2.X && p1.Y == p2.Y);
    }
    public static bool operator !=(Point p1, Point p2)
    {
        return (p1.X != p2.X || p1.Y != p2.Y);
    }
    public static bool operator <(Point p1, Point p2)
    {
        return p1.CompareTo(p2) < 0;
    }
    public static bool operator >(Point p1, Point p2)
    {
        return p1.CompareTo(p2) > 0;
    }
    public static bool operator <=(Point p1, Point p2)
    {
        return p1.CompareTo(p2) <= 0;
    }
    public static bool operator >=(Point p1, Point p2)
    {
        return p1.CompareTo(p2) >= 0;
    }

}