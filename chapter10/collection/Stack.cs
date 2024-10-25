public static class StackCode
{
    public static void Prog()
    {
        Stack<Person> stack = new Stack<Person>();
        stack.Push(new Person("Noa", "Noa", 23));
        stack.Push(new Person("Aman", "Shah", 23));
        stack.Push(new Person("John Bon", "Jovi", 50));
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());
        Console.WriteLine(stack.Pop());
    }
}