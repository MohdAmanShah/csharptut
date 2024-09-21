using Packt.Shared;
partial class Program
{
    private static void OutputPeopleName(IEnumerable<Person> people, string title)
    {
        WriteLine(title);
        foreach (Person? person in people)
        {
            WriteLine($" {(person is null ? "<null> Person" : person.Name)}");
        }
    }
}