using System.Windows.Markup;

public static class QueueCode
{
    public static void Prog()
    {
        Queue<Person> values = new();
        values.Enqueue(new Person("Johnny", "Silverhand", 70));
        values.Enqueue(new Person("Vincent", "Legend", 31));
        values.Enqueue(new Person("Alt", "Cunningham", 70));
        values.Enqueue(new Person("Hanako", "Arasaka", 78));
        Console.WriteLine(values.Peek());
        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values.Peek());
        Console.WriteLine(values.Dequeue());
        Console.WriteLine(values.Peek());
        Console.WriteLine(values.Dequeue());
        var value = values.Dequeue();
        Console.WriteLine(value);
    }
}
public static class PriorityQueueCode
{
    public static void Prog()
    {
        PriorityQueue<Person, int> values = new();
        values.Enqueue(new Person("John", "Cena", 44), 1);
        values.Enqueue(new Person("Dwayne", "Johnson", 45), 2);
        values.Enqueue(new Person("Ant", "Man", 12), 3);
        values.Enqueue(new Person("Godzilla", "Godzilla", 9000), 2);
        while (values.Count > 0)
        {
            Console.WriteLine(values.Dequeue());
        }
    }
}