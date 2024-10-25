using System.Runtime.CompilerServices;

public static class SortedSet
{
    public static void Prog()
    {
        SortedSet<Person> s = new SortedSet<Person>(new SortPeopleByAge())
        {
            new Person("John", "Cena", 44),
            new Person("Dwayne", "Johnson", 45),
            new Person("Brock", "Lesner", 50),
            new Person("Noa", "Noa", 23)
        };
        foreach (Person p in s)
        {
            Console.WriteLine(p.ToString());
        }
        s.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
        s.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
        foreach (Person p in s)
        {
            Console.WriteLine(p);
        }
    }
}

class SortPeopleByAge : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x is not null && y is not null)
            return x.Age - y.Age;
        return x is not null ? 1 : y is not null ? -1 : 0;
    }
}