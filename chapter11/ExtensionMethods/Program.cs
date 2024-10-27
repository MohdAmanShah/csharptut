using System.Reflection;
int a = 1234567890;
Console.WriteLine(a);
Console.WriteLine(a.ReverseDigits());
static class Extensions
{
    public static void DisplayDefiningAssembly(this object obj)
    {
        Console.WriteLine("{0} lives here: => {1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetType().Name);
    }
    public static int ReverseDigits(this int i)
    {
        int j = 0;
        while (i > 0)
        {
            j *= 10;
            j += i % 10;
            i /= 10;
        }
        return j;
    }
}