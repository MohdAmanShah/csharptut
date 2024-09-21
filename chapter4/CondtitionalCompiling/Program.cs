using System;
if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
{
    Console.WriteLine("build on Windows");
}

else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
{
    Console.WriteLine("build on Linux");
}

else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
{
    Console.WriteLine("build on OSX");

}
#if Linux
Console.WriteLine("Running on linux");
#elif Windows
Console.WriteLine("Running on Windows");
#elif OSX
Console.WriteLine("Running on OSX");
#endif