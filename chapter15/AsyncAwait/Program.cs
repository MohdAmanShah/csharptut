Console.WriteLine("Fun With Async ===>");
await DoWorkAsync().ConfigureAwait(false);
Console.WriteLine("Completed");
Console.ReadKey();
static string DoWork()
{
    Thread.Sleep(5000);
    return "Done with work";
}

static async Task DoWorkAsync()
{
    await Task.Run(() =>
    {
        Thread.Sleep(5000);
        Console.WriteLine("Thread work done");
    });
}