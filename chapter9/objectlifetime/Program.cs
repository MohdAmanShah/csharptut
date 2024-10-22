while (true)
{
    new SomeClass("A", 2);
}
Console.ReadKey();


class SomeClass : Object
{
    public string A { get; set; }
    public int B { get; set; }
    public SomeClass(string a, int b)
    {
        A = a;
        B = b;
    }
    ~SomeClass()
    {
        Console.Beep();
    }
}