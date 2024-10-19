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
            CurrentSpeed += delta;
            if (CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = 0;
                _isCarDead = true;
                throw new CarIsDeadException($"{PetName} the car has met it's maker.")
                {
                    HelpLink = @"D:\Work\tutorials\languages\CSharp\chapter7\Exceptions\fix.html",
                    Data ={
                        {"TimeStamp",$"The Car dies at {DateTime.Now}"},
                        {"Cause","You have a lead foot."}
                    }
                };
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
        }
        catch (Exception e)
        {
            Console.WriteLine("\n*** Error! ***");
            Console.WriteLine("Member name: {0}", e.TargetSite);
            Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
            Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
            Console.WriteLine("Message: {0}", e.Message);
            Console.WriteLine("Source: {0}", e.Source);
            Console.WriteLine("Stack: {0}", e.StackTrace);
            Console.WriteLine("Helplink: {0}", e.HelpLink);
            foreach (DictionaryEntry entry in e.Data)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }
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