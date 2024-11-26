using System.Data;

public abstract class Car
{
    public string? PetName { get; set; }
    public int CurrentSpeed { get; set; }
    public int MaxSpeed { get; set; }
    protected EngineStateEnum state = EngineStateEnum.EngineAlive;
    public EngineStateEnum EngineState => state;
    public abstract void TurboBoost();
    protected Car() { }
    protected Car(string name, int maxSpeed, int currentSpeed)
    {
        PetName = name;
        CurrentSpeed = currentSpeed;
        MaxSpeed = maxSpeed;
    }
}