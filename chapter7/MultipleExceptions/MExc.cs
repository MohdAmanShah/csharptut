using System.Collections;

namespace exc;
class Radio
{
    public void TurnOn(bool on)
    {
        Console.WriteLine(on ? "Jamming.. " : "Quite Time...");
    }
}

class Car
{
    public const int MaxSpeed = 100;
    public int CurrentSpeed { get; set; } = 0;
    public string PetName { get; set; } = string.Empty;
    private bool _isCarDead;
    private readonly Radio _theMusicBox = new Radio();
    public Car() { }
    public Car(string name, int speed)
    {
        CurrentSpeed = speed;
        PetName = name;
    }
    public void CrankTunes(bool state)
    {
        _theMusicBox.TurnOn(state);
    }
    public void Accelerate(int delta)
    {
        if (_isCarDead)
        {
            Console.WriteLine("{0} is out of order.", PetName);
        }
        else
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(delta), "argument out of range exception.");
            }
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = 0;
                _isCarDead = true;
                throw new Exception($"Car is dead exception.");
            }
            else
            {
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
    public static void Run()
    {
        Car myCar = new Car("Zippy", 20);
        myCar.CrankTunes(true);
        try
        {
            for (int i = 0; i < 10; i++)
            {
                myCar.Accelerate(10);
            }
            myCar.Accelerate(-10);
        }

        catch (CarIsDeadException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}

[System.Serializable]
public class CarIsDeadException : System.Exception
{
    public CarIsDeadException() { }
    public CarIsDeadException(string message) : base(message) { }
    public CarIsDeadException(string message, System.Exception inner) : base(message, inner) { }
    protected CarIsDeadException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}