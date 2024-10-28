Methods methods = new();
BinaryOperator<int> binaryOperator = new BinaryOperator<int>(methods.Add);
binaryOperator += methods.Subtract;
binaryOperator(123, 32);
foreach (var method in binaryOperator.GetInvocationList())
{
    Console.WriteLine(method.Method);
    Console.WriteLine(method.Target);
    method.DynamicInvoke(1, 21);
}

PointIn3D pointIn3D = new PointIn3D(12, 32, 32);
Point p = pointIn3D;
Console.WriteLine(pointIn3D);
Console.WriteLine(p);
delegate void BinaryOperator<T>(T a, T b);
class Methods
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
}

class Point
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
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.X + b.X, a.Y + b.Y);
    }
}
class PointIn3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public PointIn3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public static implicit operator Point(PointIn3D p)
    {
        return new Point(p.X, p.Y);
    }
    public override string ToString()
    {
        return $"[{X}, {Y}, {Z}]";
    }
}