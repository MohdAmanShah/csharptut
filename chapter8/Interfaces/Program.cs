SomeClass s = new SomeClass(5, 4);
AnotherClass a = new AnotherClass() { N = 3, S = 4 };
SomeFunction(s);
void SomeFunction(IInterface e)
{
    Console.WriteLine(e.P);
}

