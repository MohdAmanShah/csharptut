using inheritence;

Employee emp = new Employee()
{
    Name = "Aman",
    Age = 23,
    Id = 0,
    Pay = 100000,
    PayType = PayTypeEnum.Hourly,
    SSN = "NOA7799"
};
Console.WriteLine(emp);

Manager manager = new Manager()
{
    Name = "Aman",
    Age = 23,
    Id = 0,
    Pay = 1000000,
    PayType = PayTypeEnum.Hourly,
    SSN = "NOA7799",
    StockOptions = 1000000
};
Console.WriteLine(manager);