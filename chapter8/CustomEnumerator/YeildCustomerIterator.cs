class One
{
    public IEnumerator<int> GetEnumerator()
    {

        Console.WriteLine("John Cena.");
        foreach (var i in Enumerable.Range(0, 10).ToList())
        {
            yield return i;
        }
        Console.WriteLine("Don Kreig.");
    }
}


class Two
{
    public IEnumerator<object> GetEnumerator()
    {
        yield return 1;
        yield return "Hello";
        yield return true;
    }
}

class Three
{
    public IEnumerator<int> GetEnumerator()
    {

        Console.WriteLine("John Cena.");
        Console.WriteLine("Don Kreig.");
        return Local();

        IEnumerator<int> Local()
        {
            foreach (var i in Enumerable.Range(0, 10).ToList())
            {
                yield return i;
            }
        }
    }
}

class Four
{
    public IEnumerable<int> GetValues()
    {
        return ActualValues();
        IEnumerable<int> ActualValues()
        {
            foreach (int i in Enumerable.Range(1, 10).ToList())
            {
                yield return i;
            }
        }
    }
}