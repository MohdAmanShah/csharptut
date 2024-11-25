// using System.Diagnostics;

// ProcessStartInfo info = new ProcessStartInfo(@".\TestDoc.docx");
// int i = 0;
// foreach (var verb in info.Verbs)
// {
//     Console.WriteLine(@$"{i++} : {verb}");
// }
// Console.WriteLine(@"");
// int option = Int32.Parse(Console.ReadLine());
// info.Verb = info.Verbs[option];
// info.UseShellExecute = true;
// info.WindowStyle = ProcessWindowStyle.Minimized;
// Process.Start(info);


using System.Diagnostics;

foreach (var process in Process.GetProcesses())
{
    Console.WriteLine(process.ProcessName);
}