using System.Data;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        var d = default(int);
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        try
        {
            var number = (from i in array where i > 4 select i).SingleOrDefault();
            Console.WriteLine(number);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
public class Methods
{
    static bool Print()
    {
        Console.WriteLine("wowo");
        return true;
    }
    public static void SomeMethod()
    {
        string[] games = new string[]{
        "Cyberpunk 2077", "Genshin Impact", "Need for Speed - Hot Pursuit", "Metal Gear Solid 5", "Call of duty 4 - Modern Warefare", "Skyrim", "Morrowind", "Oblivion"
    };
        var newlist = from g in games
                      where !g.Contains(" ") && Print()
                      orderby g
                      select g;
        foreach (var game in newlist)
        {
            Console.WriteLine(game);
        }
        var newerlist = games.Where(g => !g.Contains(" ")).OrderBy(g => g).Select(g => g);
        foreach (var i in newerlist)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine(newerlist.GetType().Assembly);
    }
    public static void changes(int[] numbers)
    {
        Console.WriteLine("************** IN Changes() **********************");
        Console.WriteLine(numbers.Length);
        Console.WriteLine(numbers[1]);
        numbers[1] = 23;
        Console.WriteLine(numbers[1]);
        Console.WriteLine("************** IN Changes() **********************");
    }
}

public class Base
{ }
public class Derived : Base { }