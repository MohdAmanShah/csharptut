using System;

namespace FunWithConfiguration;

public class Car
{
    public string? Make { get; set; }
    public string? Name { get; set; }
    public string? Colour { get; set; }
    public Car() { }
    public Car(string Make, string Name, string Colour)
    {
        this.Make = Make;
        this.Name = Name;
        this.Colour = Colour;
    }
    public override string ToString()
    {
        return $$"""{Make: {{Make}}; Name: {{Name}}; Colour: {{Colour}}}""";
    }
}
