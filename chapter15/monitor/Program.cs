int val = 23;
Interlocked.CompareExchange(ref val, 232,32);
Interlocked.Exchange(ref val, 232);
Console.WriteLine(val);



void fun1()
{
    Printer p = new();
    Thread[] threads = new Thread[10];
    for (int i = 0; i < threads.Length; i++)
    {
        threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
        {
            Name = $"Thread #{i}"
        };
    }
    foreach (Thread T in threads)
    {
        T.Start();
    }

}
public class Printer()
{
    public void PrintNumbers()
    {
        Monitor.Enter(this);
        try
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} running");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                Console.Write($"[{Thread.CurrentThread.Name}: {i}] ");
            }
        }
        finally
        {
            Monitor.Exit(this);
        }
        Console.WriteLine("");
        for (int i = 65; i < 75; i++)
        {
            Thread.Sleep(300);
            Console.Write($"[{Thread.CurrentThread.Name}: {(char)i}] ");
        }
        Console.WriteLine("");
    }
}