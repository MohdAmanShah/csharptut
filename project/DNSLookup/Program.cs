Console.WriteLine("");
foreach (string hostname in args)
{
    try
    {
        if (CheckDomainName(hostname) == true)
        {
            ResolveHostName(hostname.ToLower());
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} is invalid hostname.", hostname);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(hostname);
        Console.WriteLine(ex.Message);
    }
}
Console.WriteLine(System.Environment.NewLine + "END OF RESULT" + System.Environment.NewLine);
