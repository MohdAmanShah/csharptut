public static class Functions
{
    public static void FunOne()
    {
        try
        {
            Console.WriteLine("fun one.");
            FunTwo();
        }
        catch (Exception ex)
        {
            Console.WriteLine("catch at one.");
            Console.WriteLine(ex.Message);
        }

    }
    public static void FunTwo()
    {
        try
        {
            Console.WriteLine("Fun two.");
            FunThree();
        }
        catch (Exception ex)
        {
            Console.WriteLine("catch at two.");
            Console.WriteLine(ex.Message);
        }
    }
    public static void FunThree()
    {
        try
        {
            Console.WriteLine("Fun three.");
            FunFour();
        }
        catch (Exception ex)
        {
            Console.WriteLine("catch at three.");
            Console.WriteLine(ex.Message);
        }
    }
    public static void FunFour()
    {
        try
        {
            Console.WriteLine("Fun four.");
            FunFive();
        }
        catch (Exception ex) when(ex.Message.Contains("E"))
        {
            Console.WriteLine("catch at four.");
            Console.WriteLine(ex.Message);
            throw (ex);
        }
    }
    public static void FunFive()
    {
        try
        {
            Console.WriteLine("Fun five.");
            throw new Exception("Error at fun five");
        }
        catch (Exception ex) when (ex.Message.Contains("G"))
        {
            Console.WriteLine("catch at five.");
            Console.WriteLine(ex.Message);
            throw;
        }
        catch( Exception ex) when (ex.Message.Contains("E"))
        {
            Console.WriteLine("man o man e occured.");
        }
    }
}