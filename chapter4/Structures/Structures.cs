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
        // ReadOnlyPoint p = new();
        // p.Display();
        // p = new(12, 32);
        // p.Display();
        RefPoint p = new RefPoint();
        Console.WriteLine("{0}:{1}", p.X, p.Y);
        PrintSomethingWrapper();
        // object h = p;

        void PrintSomethingWrapper()
        {
            PrintSomething();
            void PrintSomething()
            {
                RefPoint p = new RefPoint();
                Console.WriteLine("{0}:{1}", p.X, p.Y);
            }
        }

    }
}

/*
Structures can't be inherited and can't inherit other classes or structures. Structures can implement interfaces and support encapsulation.

In stuctures the default values or members are assigned only when we create structure variable using 'new' keyword. When creating variable without new keyword, all the members must be assigned before using the struct. 
Ex - 
public struct Point
{
    public int X;
    public int Y;
    public void Display()
    {
        Console.WriteLine("({0}:{1})", X, Y);
    }
}
  private static void Runner()
    {
        Point p1 = new Point();
// here p1.X and p1.Y defualts to 0.
        p1.Display();

        Point p2;
// here we need to manualy set the values of all members of p2, or else we get error : error CS0165: Use of unassigned local variable 'p2'.
        p2.X = 10;
        p2.Y = 20;
        p2.Display();
    }

readonly structures: the fields or properties must assigned a values in the constructor.

structure with
    private field,
    public properties
    must be initialised with new, because we can't use a property whose storage field is not initialised.
*/


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

public readonly struct ReadOnlyPoint
{
    public int X { get; }
    public int Y { get; }
    public ReadOnlyPoint(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void Display()
    {
        Console.WriteLine("({0}:{1})", X, Y);
    }
}

public struct ReadOnlyMembersPoint
{
    public int X { get; set; }
    public readonly int Y;
    public readonly int Z { get; }
    public ReadOnlyMembersPoint(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public void Display()
    {
        Console.WriteLine("{0}:{1}:{2}", X, Y, Z);
    }
}

public ref struct RefPoint
{
    public int X;
    public int Y;
    public RefPoint(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public struct Animals
{
    public int Count;
    Animal animal;
    List<Animals> AnimalList;
}
public class Animal
{
    public string Name { get; set; }
    public byte Age { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine("{0} is {1} years old.", Name, Age);
    }
}


