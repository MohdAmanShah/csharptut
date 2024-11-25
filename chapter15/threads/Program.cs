NewThreadWithParameterStart();
static void NewThreadWithParameterStart()
{
    AutoResetEvent wait = new AutoResetEvent(false);
    Thread mt = Thread.CurrentThread;
    mt.Name = "Primary";
    Adder d = new Adder(1, 23, wait);
    ParameterizedThreadStart pts = new ParameterizedThreadStart(d.Add);
    Thread nt = new Thread(pts);
    nt.Start(d);
    nt.Name = "Secondary Thread";
    wait.WaitOne();
    Console.WriteLine("Other Thread is done");
}


static void ThreadNew()
{
    Printer p = new();
    ThreadStart start = new ThreadStart(p.PrintNumbers);
    Thread t = new Thread(start);
    Thread pt = Thread.CurrentThread;
    pt.Name = "Primary";
    t.Name = "Secondary";
    t.Priority = ThreadPriority.Normal;
    t.Start();
    Console.WriteLine(pt.Name + " Executing");
    foreach (int i in Enumerable.Range(12, 10))
    {
        Console.Write("{0} ", i);
        Thread.Sleep(1000);
    }
    Console.WriteLine("We on the main thread");
}

static void ThreadStat()
{
    Thread currThread = Thread.CurrentThread;
    currThread.Name = "Primary Thread";
    Console.WriteLine(currThread.Name);
    Console.WriteLine(currThread.ManagedThreadId);
    Console.WriteLine(currThread.IsAlive);
    Console.WriteLine(currThread.Priority);
    Console.WriteLine(currThread.ThreadState);

}
public class Printer
{
    public void PrintNumbers()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} -> Executing PrintNumbers()");
        Console.WriteLine("Your numbers");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", i);
            Thread.Sleep(1000);
        }
    }
} 

public class Adder
{
    public int a, b;
    AutoResetEvent waitHandle;
    public Adder(int n1, int n2, AutoResetEvent w)
    {
        a = n1;
        b = n2;
        waitHandle = w;
    }
    public void Add(object? a)
    {
        if (a is Adder add)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} add the numbers {add.a}, {add.b} and the result is {add.a + add.b}");
            waitHandle.Set();
        }

    }
}

