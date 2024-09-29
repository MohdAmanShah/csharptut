/*
Tuples are light weight constructs. They are one of the mechanism to get multiples 
return values from a method call.
The don't have any data validation methods nor we can create our custom methods for it.

Starting from c# 7 each field in tuple can be named.

The field names are only visible at compile time. They are not present in the runtime.

Nesting of tuple is allowed.

*/


class User
{
    public string Name = String.Empty;
    public int Age;
    public (string, int) Deconstruct() => (Name, Age);
    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}

public struct Point
{
    public int X;
    public int Y;
    public (int, int) Deconstruct() => (X, Y);
    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}


public partial class Program
{


    static (int a, int b) ReturnTuple()
    {
        return (23, 3244);
    }

    static (string firstname, string middlename, string lastname) ReturnNames()
    {
        return ("Mohd", "Aman", "Shah");
    }


    static string RockPaperScissor(string user, string cpu)
    {
        return (user, cpu) switch
        {
            ("rock", "paper") => "cpu won",
            ("paper", "rock") => "user won",
            ("rock", "scissor") => "user won",
            ("scissor", "rock") => "cpu won",
            ("scissor", "paper") => "user won",
            ("paper", "scissor") => "cpu won",
            _ => "tie"
        };
    }

    static string Quadrunt(Point p)
    {
        return p.Deconstruct() switch
        {
            (0, 0) => "Origin",
            var (x, y) when x > 0 && y > 0 => "One",
            var (x, y) when x < 0 && y > 0 => "Two",
            var (x, y) when x < 0 && y < 0 => "Three",
            var (x, y) when x > 0 && y < 0 => "Four",
            var (_, _) => "On axis"
        };
    }

    static string Quadrunt2(Point p)
    {
        return p switch
        {
            (0, 0) => "Origin",
            var (x, y) when x > 0 && y > 0 => "One",
            var (x, y) when x < 0 && y > 0 => "Two",
            var (x, y) when x < 0 && y < 0 => "Three",
            var (x, y) when x > 0 && y < 0 => "Four",
            var (_, _) => "On axis"
        };
    }

}