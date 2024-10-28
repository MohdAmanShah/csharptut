Del<int> del = new Del<int>(Square);
del += Cube;
del(10);
Action<int> action = Cube;
action += Square;
action(12);
Func<int, int> func = Cube2;
Console.WriteLine("Cube of {0} is {1}", 11, func(11));
static int Cube2(int x)
{
    return x * x * x;
}
static void Cube(int value)
{
    Console.WriteLine("Cube of {0} is {1}", value, Math.Pow((double)value, 3.0F));
}
static void Square(int value)
{
    Console.WriteLine("Square of {0} is {1}", value, Math.Pow((double)value, 2.0F));
}
public delegate void Del<T>(T value);