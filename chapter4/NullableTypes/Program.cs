string? Name = null;
TestClass? nullClass = null;
TestClass nonNullClass = nullClass ?? new();
nonNullClass.Age = 12;

Name = "Aman";

Console.WriteLine(Name);

#nullable disable
TestClass nonNullClsass = nullClass;
#nullable restore
TestClass? BadDefiniation = nullClass;

int? number = null;
number ??= 22; // This assignment will only work if LHS is null. it will work in this line
number ??= 21;// assignment will not work here as the LHS is non null.
Console.WriteLine(number);

string[]? names = { "Aman", "Noa" };
CheckingArray(null);
CheckingArray(names);
CheckingArrayNew(null);
CheckingArrayNew(names);

void CheckingArray(string[]? names)
{
    if (names != null)
    {
        Console.WriteLine("You sent me an array of size {0}", names.Length);
    }
    else
    {
        Console.WriteLine("You sent me an array of size 0");
    }
}

void CheckingArrayNew(string[]? names)
{
    // the null condition operators names?.Length, It don't cause runtime error when accessing the Length Property on the 
    // null variable. 
    Console.WriteLine("You sent me an array of size {0}", names?.Length ?? 0);
}
