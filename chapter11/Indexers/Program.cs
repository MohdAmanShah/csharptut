using System.Collections;
using System.Data;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();
        Methods.TwoDArrayExample();
    }
}

public class Methods
{
    public static void TwoDArrayExample()
    {
        TwoDArray d = new TwoDArray();
        d[1, 2] = 123;
        Console.WriteLine(d[1, 2]);
    }
    public static void DataTableExample()
    {
        DataTable Table = new();
        Table.Columns.Add(new DataColumn("First Name"));
        Table.Columns.Add(new DataColumn("Last Name"));
        Table.Columns.Add(new DataColumn("Age"));
        Table.Rows.Add("Mohd Aman", "Shah", 23);
        Console.WriteLine(Table.Rows[0][0]);
        Console.WriteLine(Table.Rows[0][1]);
        Console.WriteLine(Table.Rows[0][2]);
    }
    public static void Carpet()
    {
        Person p = new Person("Ron", 24);
        Console.WriteLine(p["Name"]);
        Console.WriteLine(p["Age"]);
        try
        {
            Console.WriteLine(p["SomeThing"]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Invalid Index");
            Console.WriteLine(ex);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine(ex.TargetSite);
        }
    }
}

public class TodoList
{
    private ArrayList Items = new ArrayList();
    public TodoList() { }
    public TodoItem this[int index]
    {
        get { return (TodoItem)Items[index]; }
        set
        {
            if (index < Items.Count && index >= 0)
                Items[index] = value;
            else
            {
                Items.Add(value);
            }
        }
    }
}

public class TodoItem
{
    public string Title { get; set; }
    public bool Completed { get; set; }
    public TodoItem(string title, bool completed)
    {
        Title = title;
        Completed = completed;
    }
    public override string ToString()
    {
        return $"[Title: {Title}; Completed: {Completed}]";
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"[Name: {Name}; Age: {Age}]";
    }
    public object this[string index]
    {
        get
        {
            return index switch
            {
                "Name" => Name,
                "Age" => Age,
                _ => throw new ArgumentOutOfRangeException(nameof(index)),
            };
        }
    }
}

class TwoDArray
{
    private int[,] Data = new int[10, 10];
    public int this[int row, int col]
    {
        get
        {
            return Data[row, col];
        }
        set
        {
            Data[row, col] = value;
        }
    }
}
