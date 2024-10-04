using System.Collections;
using System.Runtime.Intrinsics.X86;

class Employee
{

    private string _employeeName;
    private int _employeeId;
    private float _currentPay;
    private int _employeeAge;
    private string _empSSN;
    private EmployeePayType _payType;
    public int SomeValue { get; }
    public Employee() { }
    public Employee(string name, int id, float pay, string ssn)
    : this(name, 0, id, pay, ssn, EmployeePayType.Salaried) { }
    public Employee(string name, int age, int id, float pay, string ssn, EmployeePayType payType)
    {
        Name = name;
        Id = id;
        Pay = pay;
        Age = age;
        SSN = ssn;
        PayType = payType;
        SomeValue = 24;
    }
    public void GiveBonus(float amount)
    {
            Pay = this switch
        {
            { PayType: EmployeePayType.Commission } => Pay += .10F * amount,
            { PayType: EmployeePayType.Salaried } => Pay += amount,
            { PayType: EmployeePayType.Hourly } => Pay += 40F * amount / 2080,
            _ => Pay += 0
        };
    }
    public void GiveBonus2(float amount)
    {
        Pay = this switch
        {
            Employee i when i.PayType == EmployeePayType.Commission => Pay += 0.10F * amount,
            Employee i when i.PayType == EmployeePayType.Salaried => Pay += amount,
            Employee i when i.PayType == EmployeePayType.Hourly => Pay += 40 * amount / 2080,
            _ => Pay += 0
        };
    }
    public override string ToString()
    {
        return string.Format(@"
        Name:{0}
        ID: {1}
        Age: {2}
        Pay: {3}", Name, Id, Age, Pay);
    }


    public string Name
    {
        get { return _employeeName; }
        set
        {
            if (value.GetType() != typeof(string))
            {
                Console.WriteLine("Invalid data type.");
            }
            if (value.Length > 15)
            {
                Console.WriteLine("Name can't have more than 15 characters");
            }
            else
            {
                _employeeName = value;
            }
        }
    }
    public int Id
    {
        get { return _employeeId; }
        set { _employeeId = value; }
    }
    public float Pay
    {
        get { return _currentPay; }
        set { _currentPay = value; }
    }
    public int Age
    {
        get { return _employeeAge; }
        set { _employeeAge = value; }
    }
    public string SSN
    {
        get { return _empSSN; }
        private set { _empSSN = value; }
    }
    public EmployeePayType PayType
    {
        get { return _payType; }
        set { _payType = value; }
    }
}

enum EmployeePayType
{
    Hourly,
    Salaried,
    Commission
}