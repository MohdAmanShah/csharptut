using System.Collections;

public static class DD
{
    public static void Prog()
    {
        ArrayList array = new ArrayList();
        array.AddRange(new string[] { "one", "two", "three", "four" });
        Console.WriteLine(array.Count);
        array.Add(5);
        Console.WriteLine(array.Count);
        foreach (object i in array)
        {
            Console.WriteLine(i);
        }
        array.Sort();
        foreach(object i in array)
        {
            Console.WriteLine(i);
        }
    }
    public static void Prog2()
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine(a[4]);
    }
}
