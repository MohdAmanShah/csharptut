public interface interface_one
{
    void doit();
}

public interface interface_two
{
    void doit();
}
public interface interface_three
{
    void doit();
}
public class class_one : interface_one, interface_two, interface_three
{
    void interface_one.doit()
    {
        Console.WriteLine("1 do it.");
    }
    void interface_two.doit()
    {
        Console.WriteLine("2 do it.");
    }
    void interface_three.doit()
    {
        Console.WriteLine("3 do it.");
    }
}