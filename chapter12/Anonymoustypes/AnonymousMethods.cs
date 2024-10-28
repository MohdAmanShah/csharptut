public class AnonymousMethods
{
    int a = 34;
    public void Prog()
    {
        int a = 3;
        AnonymousMethods m = new();
        DoSomething();
        ref int b = ref a;
        ++b;
        DoSomething();
        void DoSomething()
        {
            int a = 2;
            Console.WriteLine(a);
            Console.WriteLine(this.a);
            Console.WriteLine(m.a);
        }
    }

}
