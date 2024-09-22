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
}