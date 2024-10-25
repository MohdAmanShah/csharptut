public static class Class
{
    public static void Prog()
    {
        Compare<int>(32, 21);
    }
    public static void Compare<T>(T a, T b)
    {
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());
    }
}