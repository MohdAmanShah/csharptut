interface IInterface
{
    int N { get; set; }
    int S { get; set; }
    int P => N * S;
    static string Prop { get; set; }
    static IInterface() => Prop = "tom";
}

class SomeClass : IInterface
{
    public int N { get; set; }
    public int S { get; set; }
    public SomeClass(int n, int s)
    {
        N = n;
        S = s;
    }
}
class AnotherClass
{
    public int N { get; set; }
    public int S { set; get; }
    public int P => N * S;
}