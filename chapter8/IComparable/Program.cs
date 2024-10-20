public class Program
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[5];
        students[0] = new Student("A", 1);
        students[1] = new Student("C", 2);
        students[2] = new Student("B", 2);
        students[3] = new Student("D", 3);
        students[4] = new Student("E", 5);
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
        Array.Sort(students, new SortByName());
        Console.WriteLine();
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public int CompareTo(Student? other)
    {
        if (other == null) return -1;
        return this.Id - other.Id;
    }
    public override string ToString()
    {
        return $"[Name = {Name}; Id = {Id}]";
    }
}

class SortByName : IComparer<Student>
{
    public int Compare(Student? x, Student? y)
    {
        if (x == null && y == null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
}