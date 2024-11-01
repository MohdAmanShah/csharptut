// using System.Diagnostics;
// using System.Runtime.InteropServices;

// // Process[] processes = Process.GetProcesses();\
// // foreach(Process process in processes)
// // {
// //     Console.WriteLine("PID: {0}, Name: {1}", process.Id, process.ProcessName);
// // }
// int Id = Int32.Parse(Console.ReadLine());
// Process singleProcess = Process.GetProcessById(Id);
// Console.WriteLine(singleProcess.ProcessName);
// ProcessThreadCollection threadCollection = singleProcess.Threads;
// foreach (ProcessThread thread in threadCollection)
// {
//     if (OperatingSystem.IsWindows())
//     {
//         Console.WriteLine("Id: {0}, Start time: {1}, Priority: {2}", thread.Id, thread.StartTime.ToShortTimeString(), thread.PriorityLevel);
//     }
// }
// ProcessModuleCollection modules = singleProcess.Modules;
// foreach (ProcessModule module in modules)
// {
//     Console.WriteLine(module.ModuleName + ", ");
//     Console.WriteLine(module.FileName + ", ");
//     Console.WriteLine(module.Container + ", ");
//     Console.WriteLine(module.FileVersionInfo + ", ");
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine("*********************************");
//     Console.ForegroundColor = ConsoleColor.White;
// }