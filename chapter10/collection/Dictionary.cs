public static class Dict
{
    public static void UseDictionary()
    {

        Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
        peopleA.Add("Homer", new Person
        {
            FirstName = "Homer",
            LastName = "Simpson",
            Age
        = 47
        });
        peopleA.Add("Marge", new Person
        {
            FirstName = "Marge",
            LastName = "Simpson",
            Age
        = 45
        });
        peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
        Person homer = peopleA["Homer"];
        Console.WriteLine(homer);
        Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
{
{ "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
{ "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
{ "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
};
        Person lisa = peopleB["Lisa"];
        Console.WriteLine(lisa);
    }
}