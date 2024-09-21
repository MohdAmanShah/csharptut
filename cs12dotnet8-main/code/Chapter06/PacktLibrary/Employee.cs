namespace Packt.Shared;
public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateOnly HireDate { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()}\nEmployeeID: {EmployeeCode}\nHired Date: {HireDate}";
    }
    public new void WriteToConsole()
    {
        WriteLine($"{Name} was born on {Born:dd/MM/yyyy} and hired on {HireDate:dd/MM/yyyy}");
    }
}