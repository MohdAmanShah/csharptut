// TimerCallback timerCallback = new TimerCallback(PrintTime);
// _= new Timer(timerCallback, "timer", 1000, 1000);
// Console.ReadKey();

Console.WriteLine(Directory.GetCurrentDirectory());
WaitCallback callback = new WaitCallback(PrintTime);
for (int i = 0; i < 5; i++)
{
    ThreadPool.QueueUserWorkItem(callback, i);
}
Console.ReadKey();
static void PrintTime(object? caller)
{
    if(caller is int t)
    while (true)
    {
        Console.WriteLine(t + ": " + DateTime.Now.ToLongTimeString());
        Thread.Sleep(1000);
    }
}