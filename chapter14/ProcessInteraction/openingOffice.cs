using System.Diagnostics;

ProcessStartInfo info = new ProcessStartInfo(@".\TestDoc.docx");
int i = 0;
foreach (var verb in info.Verbs)
{
    Console.WriteLine(@$"{i++} : {verb}");
}
info.Verb = "Print";
info.UseShellExecute = true;
Process.Start(info);