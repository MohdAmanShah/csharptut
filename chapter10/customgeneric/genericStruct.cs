
using System.Security.Cryptography;

Point<int> p = new Point<int>(1, 2);
Point<double> p1 = new Point<double>(3.4, 1.2);
Point<string> p2 = new Point<string>("\"", "11");
p.ResetPoint();
p1.ResetPoint();
p2.ResetPoint();
Console.WriteLine(p);
Console.WriteLine(p1);
Console.WriteLine(p2);
Point<int> q = default;
Console.WriteLine(q);

PatternMatching(p);
PatternMatching(p1);
PatternMatching(p2);

static void PatternMatching<T>(Point<T> p)
{
    switch (p)
    {
        case Point<int> pInt:
            Console.WriteLine("P is integer.");
            break;
        case Point<string> pString:
            Console.WriteLine("P is string.");
            break;
        default:
            Console.WriteLine("P is {0}", typeof(T).Name);
            break;
        case Point<double> pDouble:
            Console.WriteLine("P is double.");
            break;
    }
}

public struct Point<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public Point(T x, T y)
    {
        X = x;
        Y = y;
    }
    public override string ToString()
    {
        return $"[{X}, {Y}]";
    }
    public void ResetPoint()
    {
        X = default(T);
        Y = default(T);
    }
}

class SomeClass<T> where T : class, ICloneable, IComparable, new()
{

}