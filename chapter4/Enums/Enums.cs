public partial class Program
{
    enum EmpTypeEnum : byte
    {
        Manager = 1,
        Grunt = 2,
        Contractor = 4,
        VicePresident = 8
    }
    private static void AskForBonus(EmpTypeEnum e)
    {
        switch (e)
        {
            case EmpTypeEnum.Manager:
                Console.WriteLine("Want stocks instead?");
                break;
            case EmpTypeEnum.Grunt:
                Console.WriteLine("are you kidding!");
                break;
            case EmpTypeEnum.Contractor:
                Console.WriteLine("You have enough cash.");
                break;
            case EmpTypeEnum.VicePresident:
                Console.WriteLine("All right.");
                break;
        }
    }

    private static void EvaluateEnum(Enum e)
    {
        Console.WriteLine("Enum type name: {0}.", e.GetType().Name);
        Console.WriteLine("Underlying type: {0}.", Enum.GetUnderlyingType(e.GetType()));
        Array enumData = Enum.GetValues(e.GetType());
        Console.WriteLine("Number of values: {0}", enumData.Length);
        for (int i = 0; i < enumData.Length; i++)
        {
            Console.WriteLine($"{enumData.GetValue(i):D}: {enumData.GetValue(i)}");
        }
    }

    private static void Runner()
    {
        EmpTypeEnum emp = EmpTypeEnum.Contractor;
        AskForBonus(emp);
        Console.WriteLine("Enum type: {0}.", emp.GetType().Name);
        Console.WriteLine("Underlying data store type: {0}.", Enum.GetUnderlyingType(emp.GetType()));
        Console.WriteLine("emp value: {0}.", emp.ToString());
        Console.WriteLine("emp underlying value: {0}.", (byte)emp);
        EvaluateEnum(emp);

        Console.Clear();
        EmpTypeEnum e1 = new EmpTypeEnum();
        DayOfWeek d = new DayOfWeek();
        ConsoleColor c = new ConsoleColor();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        EvaluateEnum(e1);
        EvaluateEnum(d);
        EvaluateEnum(c);

        Console.Clear();
        Console.WriteLine(Convert.ToString(Int32.MinValue));
        Console.WriteLine(Convert.ToString(Int32.MinValue, 2));
        Console.WriteLine(Convert.ToString(Int32.MaxValue));
        Console.WriteLine(Convert.ToString(Int32.MaxValue, 2));

        Console.WriteLine(emp);
        emp = EmpTypeEnum.Grunt;
        Console.WriteLine(emp);
        Console.WriteLine((byte)emp);
        Console.WriteLine(Convert.ToString(22, 2));
        Console.WriteLine(Convert.ToString(22, 8));
    }

    [Flags]
    enum ContactPreferenceEnum : byte
    {
        None = 1,
        Email = 2,
        Phone = 4,
        Fax = 8
    }
}