public class Program
{
    public static void Main(string[] args)
    {
        Car c1 = new Car("Zippy", 200, 20);
        c1.AboutToBlow += CarAboutBlow;
        c1.Exploded += CarExploded;
        foreach (int i in Enumerable.Range(1, 10))
        {
            c1.Accelerate(24);
        }
    }
    static void DoIt()
    {
        Console.WriteLine("Don't ");
    }
    static void CarAboutBlow(object? sender, CarEventArgs e)
    {
        if (sender is Car c)
        {
            Console.WriteLine($"{c.Name} says: {e.msg}");
        }
        else
        {
            Console.WriteLine(e.msg);
        }
    }
    static void CarExploded(object? sender, CarEventArgs e)
    {
        if (sender is Car c)
        {
            Console.WriteLine($"{c.Name} says: {e.msg}");
        }
        else
        {
            Console.WriteLine(e.msg);
        }
    }
}
public class Car
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public int CurrentSpeed { get; set; }
    private bool _isCarDead;
    public Car(string name, int maxSpeed, int currentSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        CurrentSpeed = currentSpeed;
    }
    public override string ToString()
    {
        return $$"""{Name:{{Name}}, Maxspeed:{{MaxSpeed}}, Current speed: {{CurrentSpeed}}}""";
    }
    public event EventHandler<CarEventArgs> Exploded;
    public event EventHandler<CarEventArgs> AboutToBlow;
    public void Accelerate(int delta)
    {
        if (_isCarDead)
        {
            Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead"));
        }
        else
        {
            CurrentSpeed += delta;
            if (MaxSpeed - CurrentSpeed < 10)
            {
                AboutToBlow?.Invoke(this, new CarEventArgs("Car about to break."));
            }
            if (CurrentSpeed >= MaxSpeed)
            {
                _isCarDead = true;
            }
            else
            {
                Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}

public class CarEventArgs : EventArgs
{
    public readonly string msg;
    public CarEventArgs(string msg)
    {
        this.msg = msg;
    }
}