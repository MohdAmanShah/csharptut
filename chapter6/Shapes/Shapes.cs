namespace Space;
public abstract class Shape
{
    public string PetName { get; set; }
    public Shape() { }
    protected Shape(string name)
    {
        PetName = name;
    }
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape.");
    }
}

public class Circle : Shape
{
    public Circle() { }
    public Circle(string name) : base(name) { }
}

public class Hexagon : Shape
{
    public Hexagon() { }
    public Hexagon(string name) : base(name) { }
    public override void Draw()
    {
        Console.WriteLine("Drawing {0} the Hexagon.", PetNamek);
    }
}