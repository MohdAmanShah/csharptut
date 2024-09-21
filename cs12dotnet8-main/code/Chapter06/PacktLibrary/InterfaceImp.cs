namespace Packt.Shared;
public interface IKeyHolder
{
    void Lose();
}
public interface IGamePlayer
{
    void Lose();
}

public class Per : IKeyHolder, IGamePlayer
{
    public void Lose()
    {
        WriteLine("I lost the key");
    }
    void IGamePlayer.Lose()
    {
        WriteLine("I lost the game");
    }
}