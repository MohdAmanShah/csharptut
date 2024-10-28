using System.Reflection.Metadata;

Car c1 = new Car("Tazr", 200, 20);

// Default method to register methods by passing delegate object
c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

// Using method group conversion shortcut
c1.RegisterWithCarEngine(OnCarEngineChangedEvent);
for (int i = 0; i < 10; i++)
{
    c1.Accelarate(25);
}
static void OnCarEngineChangedEvent(string msg)
{
    Console.WriteLine("Ran after engine change occured: {0}", msg);
}
static void OnCarEngineEvent(string msg)
{
    Console.WriteLine(msg);
}
public class Car
{
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    public string Name { get; set; } = String.Empty;
    private bool _isCarDead;
    public Car() { }
    public Car(string name, int maxSpeed, int currentSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
        CurrentSpeed = currentSpeed;
    }
    public delegate void CarEngineHandler(string msdForCaller);
    private CarEngineHandler? _listOfHandlers;
    public void RegisterWithCarEngine(CarEngineHandler methodToCall)
    {
        _listOfHandlers += methodToCall;
    }
    public void UnRegisterWithCarEngine(CarEngineHandler methodToRemove)
    {
        _listOfHandlers -= methodToRemove;
    }
    public void Accelarate(int delta)
    {
        if (_isCarDead)
        {
            _listOfHandlers?.Invoke("Sorry, this car is dead.");
        }
        else
        {
            CurrentSpeed += delta;
            if (10 > (MaxSpeed - CurrentSpeed))
            {
                _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
            }
            if (CurrentSpeed >= MaxSpeed)
            {
                _isCarDead = true;
            }
            else
            {
                Console.WriteLine("Current speed = {0}", CurrentSpeed);
            }
        }
    }
}