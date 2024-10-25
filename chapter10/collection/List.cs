public static class ListCode
{
    public static void Prog()
    {
        List<Person> Persons = new List<Person>()
{
    new Person("Ron", "Wheesley", 24),
    new Person("Harry", "Potter", 24),
    new Person("Noa", "Noa", 23)
};
        Persons.Add(new Person("John", "Bon Jovi", 34));
        Persons.Insert(0, new Person("The", "Rock", 45));
        foreach (Person person in Persons)
        {
            Console.WriteLine(person);
        }
    }
}