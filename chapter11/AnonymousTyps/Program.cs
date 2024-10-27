var car = new { Make = "Honda", Color = "White", Speed = "200" };
Console.WriteLine(car);
var newCar = new { Make = "Honda", Color = "White", Speed = "200" };
Console.WriteLine(car == newCar);
Console.WriteLine(car.GetHashCode());
Console.WriteLine(newCar.GetHashCode());
Console.WriteLine(car.Equals(newCar));