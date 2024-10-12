using System.Runtime.InteropServices.Marshalling;

public record Car
{
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }
    public Car(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }
}
public sealed record MiniVan : Car
{
    public int Seating { get; init; }
    public MiniVan(string make, string model, string color, int seating)
    : base(make, model, color)
    {
        Seating = seating;
    }
}