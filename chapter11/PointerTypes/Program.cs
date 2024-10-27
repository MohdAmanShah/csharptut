unsafe
{
    int a = 3;
    SqaureInteger(&a);
    int* b = &a;
    *b = *b + 23;
    Console.WriteLine(a);
    Console.WriteLine(*b);
    Console.WriteLine((int)b);
    Console.WriteLine((int)&a);
    Node node = new Node(23);
    Node* n = &node;
    Console.WriteLine((*n).value);
    Console.WriteLine(n->value);
}
static unsafe void SqaureInteger(int* number)
{
    *number *= *number;
}
struct Node
{
    public int value;
    public Node? next;
    public Node? prev;
    public Node(int value)
    {
        this.value = value;
        next = null;
        prev = null;
    }
}