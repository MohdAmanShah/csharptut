
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

public partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    public const string pattern = @"^(?!-)[A-Za-z0-9-]{1,63}(?<!-)\.[A-Za-z]{2,6}(\.[A-Za-z]{2,})?$";
    public static void ResolveHostName(string hostname = "www.bing.com")
    {
        System.Net.IPHostEntry hostEntry = System.Net.Dns.GetHostEntry(hostname);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("passed domain: {0}", hostname);
        Console.WriteLine("recieved domain: {0}", hostEntry.HostName);
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        foreach (System.Net.IPAddress address in hostEntry.AddressList)
        {
            Console.WriteLine(address.ToString());
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("**************************************************************************");
    }

    public static bool CheckDomainName(string hostname)
    {
        Regex regex = new Regex(pattern);
        return regex.IsMatch(hostname);
    }
}
