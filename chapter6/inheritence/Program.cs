using inheritence;
Console.WriteLine("***** The Employee Class Hierarchy *****\n");
Manager chucky = new Manager("Chucky", 50, 92, "333-23-2322", 10000, 9000);
double cost = chucky.GetBenefitCost();
Console.WriteLine($"Benefit Cost: {cost}");
Console.ReadLine();