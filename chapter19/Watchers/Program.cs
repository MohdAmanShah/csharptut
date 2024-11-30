FileSystemWatcher watcher = new FileSystemWatcher();
try
{
    watcher.Path = @".";
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message));
    return;
}
watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess | NotifyFilters.FileName | NotifyFilters.DirectoryName;

watcher.Filter = "*.txt";

watcher.Changed += (s, e) =>
    Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
watcher.Created += (s, e) =>
     Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
watcher.Deleted += (s, e) =>
    Console.WriteLine($"File: {e.FullPath} {e.ChangeType}");
watcher.Renamed += (s, e) =>
    Console.WriteLine($"File: {e.OldFullPath} renamed to {e.NewFullPath}");

watcher.EnableRaisingEvents = true;
Console.WriteLine(@"Press 'q' to quit app");

using (var sw = File.CreateText("Test.txt"))
{
    sw.Write("Dog is Dog.");
}
File.Move("Test.txt", "Test2.txt");
File.Delete("Test2.txt");
while (Console.ReadKey().Key != ConsoleKey.Q) ;
