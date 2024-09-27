public partial class Program
{
    private static void FunOne()
    {
        int? value = 0;
        Nullable<int> secondValue = null;
        Console.WriteLine(value);
        Console.WriteLine(secondValue);

        Console.WriteLine(secondValue.HasValue);
    }
}

class TestClass
{
    public string Name;
    public int Age;
}