using System.Transactions;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks.");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Animal eats.");
    }
    public virtual void Sleep()
    {
        Console.WriteLine("Animal sleeps.");
    }
    public virtual void Run()
    {
        Console.WriteLine("Animal runs.");
    }
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog eats.");
    }
    public override void Speak()
    {
        Console.WriteLine("Dog speaks.");
    }
    public override void Run()
    {
        Console.WriteLine("Dog runs.");
    }
    public override void Sleep()
    {
        Console.WriteLine("Dog sleeps");
    }
}