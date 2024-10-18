Person p1 = new Person("Ron", 22, "1111-1111-22");
Person p2 = new Person("Harry", 21, "1111-2222-22");
Person p3 = p1;
Person p4 = new Person("Ron", 22, "1111-1111-22");


Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.WriteLine(p4);
Console.WriteLine(p1.Equals(p2));
Console.WriteLine(p1.Equals(p3));
Console.WriteLine(p1.Equals(p4));
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(p2.GetHashCode());
Console.WriteLine(p3.GetHashCode());
Console.WriteLine(p4.GetHashCode());


class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string SSN { get; }
    public Person() : this(string.Empty, default, ssn: "1111-1111-21") { }
    public Person(string name, int age, string ssn)
    {
        Name = name;
        Age = age;
        SSN = ssn;
    }
    public override bool Equals(object? obj)
    {
        return obj?.ToString() == ToString();
    }
    public override string ToString()
    {
        return $"[Name: {Name}; Age: {Age}; SSN: {SSN}]";
    }
    public override int GetHashCode()
    {
        return SSN.GetHashCode();
    }
}

