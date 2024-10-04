using System.Collections.Specialized;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public Car() { }
    public Car(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }
    public override string ToString()
    {
        return string.Format("Make: {0}{3}Model: {1}{3}Color: {2}{3}", Make, Model, Color, System.Environment.NewLine);
    }
}


record CarRecord // same as record class CarRecord
{
    public string Make { get; init; }
    public string Model { get; init; }
    public string Color { get; init; }
    public CarRecord() { }
    public CarRecord(string make, string model, string color)
    {
        Make = make;
        Model = model;
        Color = color;
    }

}
record CarRecord2(string Make, string Model, string Color);