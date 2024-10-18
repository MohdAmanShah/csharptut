using Poly;

object obj = new SomeClass();
((SomeClass)obj).SomeMethod();


if (obj is SomeClass someClass)
{
    someClass.SomeMethod();
}
if (obj is AnotherClass anotherClass)
{
    anotherClass.SomeMethod();
}