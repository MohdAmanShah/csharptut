using System;
using System.Security.Cryptography;
using System.Text;
public partial class Employee
{
    protected static StringBuilder _toString = new StringBuilder();
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Id { get; set; }
    public string? SSN { get; init; }
    public int Pay { get; set; }
    public PayTypeEnum PayType { get; set; }
    public Employee() { }
    public Employee(string name, int age, int id, string ssn, int pay) : this(name, age, id, ssn, pay, PayTypeEnum.Salaried)
    { }
    public Employee(string name, int age, int id, string ssn, int pay, PayTypeEnum payType)
    {
        Name = name;
        Age = age;
        Id = id;
        SSN = ssn;
        Pay = pay;
        PayType = payType;
    }
    public override string ToString()
    {
        _toString.Append("{\n");
        _toString.Append("\tId:" + Id + Environment.NewLine);
        _toString.Append("\tName:" + Name + Environment.NewLine);
        _toString.Append("\tAge:" + Age + Environment.NewLine);
        _toString.Append("\tPay:" + Pay + Environment.NewLine);
        _toString.Append("\tPaytype:" + PayType + Environment.NewLine);
        _toString.Append("\tSocial Security Number:" + SSN + Environment.NewLine);
        _toString.Append("}\n");
        return _toString.ToString();
    }
}


public class Manager : Employee
{
    public int StockOptions { get; set; }
    public Manager() : base() { }
    public Manager(string name, int age, int id, string ssn, int pay, int stockoptions)
    : base(name, age, id, ssn, pay, PayTypeEnum.Salaried)
    {
        StockOptions = stockoptions;
    }
    public override string ToString()
    {
        base.ToString();
        _toString.Remove(_toString.Length - 2, 2);
        _toString.Append("\tStock Option: " + StockOptions + Environment.NewLine);
        _toString.Append("}\n");
        return _toString.ToString();
    }
    public override void GiveBonus(int amount)
    {
        base.GiveBonus(amount);
        Random r = new Random();
        StockOptions += r.Next(500);
    }
}

public class SalesPerson : Employee
{
    public int NumberOfSales { get; set; }
    public SalesPerson(string name, int age, int id, string ssn, int pay, int numberofsales)
    : base(name, age, id, ssn, pay, PayTypeEnum.Commission)
    {
        NumberOfSales = numberofsales;
    }
    public override sealed void GiveBonus(int amount)
    {
        int salesBonus = 0;
        if (NumberOfSales is > 0 and < 100)
        {
            salesBonus = 10;
        }
        else
        {
            if (NumberOfSales is > 100 and <= 200)
            {
                salesBonus = 15;
            }
            else
            {
                salesBonus = 20;
            }
        }
        base.GiveBonus(amount * salesBonus);
    }
}
