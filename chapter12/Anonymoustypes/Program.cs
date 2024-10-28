using System.Runtime.Intrinsics.Arm;

public class Program
{
    static void Prog()
    {
        Car c1 = new Car("Zippy", 200, 20);
        c1.Exploded += delegate (object? sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        };
        c1.Exploded += delegate
        {
            Console.WriteLine("Dead");
        };
        c1.AboutToBlow += static delegate (object? sender, CarEventArgs e)
        {
            Console.WriteLine(e.msg);
        };
        for (int i = 0; i < 10; i++)
        {
            c1.Accelerate(20);
        }
    }
    public static void Main(string[] args)
    {
        Prog();
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