Garage g = new();

g.AddCar(new Car("Bolero", 160));
g.AddCar(new Car("Indigo", 180));
g.AddCar(new Car("Buggati", 400));
g.AddCar(new Car("Rolls royce", 260));
g.AddCar(new Car("Koensegg", 360));


foreach (Car c in g)
{
    Console.WriteLine(c.Name);
}