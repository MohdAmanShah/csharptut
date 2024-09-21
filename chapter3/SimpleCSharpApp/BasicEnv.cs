partial class Program
{
    public static void Main(string[] args)
    {
        foreach(var drive in System.Environment.GetLogicalDrives())
        {
            System.Console.WriteLine(drive);
        }
        System.Console.WriteLine($"The number of processors are: {System.Environment.ProcessorCount}");
        System.Console.WriteLine($"The OS version is: {System.Environment.OSVersion}");
        System.Console.WriteLine($".Net core version: {System.Environment.Version}");
        System.Console.WriteLine($"Is 64-bit computer?: {System.Environment.Is64BitOperatingSystem}");
        System.Console.WriteLine($"Machine name: {System.Environment.MachineName}");
        System.Console.WriteLine($"New line symbol: {System.Environment.NewLine}");
        System.Console.WriteLine($"Process id: {System.Environment.ProcessId}");
        System.Console.WriteLine($"Process path: {System.Environment.ProcessPath}");
        System.Console.WriteLine($"Username: {System.Environment.UserName}");
    }
}