namespace Poly;

class SomeClass
{
    public void SomeMethod()
    {
        Console.WriteLine("Do something.");
    }
}


class AnotherClass : SomeClass
{
    public new void SomeMethod()
    {
        Console.WriteLine("Do something other than what previous class did.");
        base.SomeMethod();
    }
}