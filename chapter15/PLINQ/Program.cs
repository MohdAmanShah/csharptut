CancellationTokenSource token = new CancellationTokenSource();
Task.Factory.StartNew(() => { ProcessArray(); });

var key = Console.ReadKey();
if (key.Key == ConsoleKey.Q)
{
    token.Cancel();
}

Console.ReadKey();
void ProcessArray()
{
    try
    {
        int[] array = Enumerable.Range(0, 10_000_000).ToArray();
        int[] multiplesOfThree = (from i in array.AsParallel().WithCancellation(token.Token)
                                  where i % 3 == 0
                                  orderby i descending
                                  select i).ToArray();
        Console.WriteLine("Count of multiples of 3: {0}", multiplesOfThree.Length);

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}