//using System.Runtime.CompilerServices;
//[assembly: InternalsVisibleTo("CarClient")]
namespace CarLibrary;
public class HiddenCar : Car
{
    public HiddenCar() { }
    public HiddenCar(string name, int currspeed) : base(name, 600, currspeed) { }
    public override void TurboBoost()
    {
        CurrentSpeed = MaxSpeed;
        Console.WriteLine("God Speed");
    }
}