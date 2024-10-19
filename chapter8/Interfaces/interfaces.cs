public abstract class Parent
{
    public string Name { get; set; }
    public Parent(string name)
    {
        Name = name;
    }
}

public class Child : Parent
{
    public Child(string name) : base(name) { }
}


interface IParent
{
    string Name { get; set; }
    static IParent()
    {
        Console.WriteLine("Hello World");
    }
}
public class someClass : IParent
{
    public string Name { get; set; }

    public someClass(string name)
    {
        Name = name;
    }
}
