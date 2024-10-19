using static SomeClass;
try
{
    Program();
}
catch (MyException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
    Console.WriteLine(e.TargetSite);
}
public class MyException : ApplicationException
{
    public MyException(string message) : base(message)
    {

    }
}

public class SomeClass
{
    public static void Program()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(i);
            if (i == 59)
            {
                throw new MyException("overflow in data.");
            }
        }
    }
}
