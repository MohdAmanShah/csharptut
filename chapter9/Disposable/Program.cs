using static System.Console;

using (SomeClass s = new SomeClass(), c = new SomeClass())
{
    
}
class SomeClass : IDisposable
{
    public void Dispose()
    {
        WriteLine("Hello, world");
    }
}

class Congres : IDisposable
{
    public void Do()
    {
        Console.WriteLine("he haw");
    }
    public void Dispose()
    {
        Console.WriteLine("no interface");
    }
}