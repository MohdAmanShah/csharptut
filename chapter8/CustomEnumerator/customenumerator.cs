using System.Collections;

class Car
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public Car(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }
}


class Garage : IEnumerable
{
    private Car[] cars = new Car[5];
    private int i;
    public Garage()
    {
        i = 0;
    }
    public void AddCar(Car car)
    {
        if (i is >= 0 and < 5)
        {
            cars[i] = car;
            ++i;
        }
    }
    public IEnumerator GetEnumerator()
    {
        return cars.GetEnumerator();
    }
}