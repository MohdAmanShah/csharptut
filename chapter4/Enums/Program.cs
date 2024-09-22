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