using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        string[] colors = new string[] { "Red", "Orange", "Blood Red", "Dark Red", "Light Red", "Pink" };
        string[] colorsRed = GetStringSubset(colors);
        foreach (string color in colorsRed)
        {
            Console.WriteLine(color);
        }
    }
    static bool Print()
    {
        Console.WriteLine("Hello");
        return true;
    }
    public static string[] GetStringSubset(string[] set)
    {
        IEnumerable<string> subset = from s in set where s.Contains("Red") && Print() select s;

        return subset.ToArray();
    }
}