Printer P = new Printer();
Thread[] threads = new Thread[10];
for (int i = 0; i < threads.Length; i++)
{
    threads[i] = new Thread(new ThreadStart(P.PrintNumbers))
    {
        Name = $"Thread #{i}"
    };
}
foreach (Thread t in threads)
{
    t.Start();
}
public class Printer
{
    public void PrintNumbers()
    {
        lock (this)
        {
            Console.WriteLine($" -> {Thread.CurrentThread.Name} is executing PrintNumbers().");
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name}: {i} ");
            }
            Console.WriteLine("");

        }
    }
}