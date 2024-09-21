using System.Diagnostics.CodeAnalysis;
public partial class Program
{
    private static void Process(string?[] lines, string mark)
    {
        foreach (string line in lines)
        {
            if (IsValid(line))
            {
                Console.WriteLine(line);
            }
        }
        bool IsValid([NotNullWhen(true)] string? line)
        {
            return !String.IsNullOrEmpty(line) && line.Length > mark.Length;
        }
    }
    private static int Add(ref int x, ref int y)
    {
        int ans = x + y;
        x = 23;
        y = 34;
        return x + y;
    }
}