namespace CarLibrary;

public class MiniVan : Car
{
    public MiniVan() { }
    public MiniVan(string name, int maxSpeed, int currentSpeed) : base(name, maxSpeed, currentSpeed) { }
    public override void TurboBoost()
    {
        state = EngineStateEnum.EngineDead;
        Console.WriteLine("Your engine is dead");
    }
}
