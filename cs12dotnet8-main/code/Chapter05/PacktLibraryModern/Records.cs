
//namespace Packt.Shared;

//public class ImmutablePerson
//{
//  public string? FirstName { get; init; }
//  public string? LastName { get; init; }
//}

//public record ImmutableVehicle
//{
//  public int Wheels { get; init; }
//  public string? Color { get; init; }
//  public string? Brand { get; init; }
//}

//// Simpler syntax to define a record that auto-generates the 
//// properties, constructor, and deconstructor.
//public record ImmutableAnimal(string Name, string Species);


public record ImmutableVehicle
{
    public int Wheels { get; set; }
    public string? Color { get; set; }
    public string? Brand { get; set; }
    public ImmutableVehicle() { }
    public ImmutableVehicle(string Color, string Brand, int Wheels)
    {
        this.Wheels = Wheels;
        this.Color = Color;
        this.Brand = Brand;
    }
    public void Deconstruct(out string Brand, out string Color)
    {
        Brand = this.Brand;
        Color = this.Color;
    }
}



public record ImmutableAnimal(string Name, string Species);


