class Motorcycle
{
    public int driverIntensity;
    public string driverName;
    // Constructor chaining.
    public Motorcycle()
    {
        Console.WriteLine("In default constructor");
    }
    public Motorcycle(int intensity)
    : this(intensity, "")
    {
        Console.WriteLine("In constructor taking an int");
    }
    public Motorcycle(string name)
    : this(0, name)
    {
        Console.WriteLine("In constructor taking a string");
    }
    // This is the 'main' constructor that does all the real work.
    public Motorcycle(int intensity, string name)
    {
        Console.WriteLine("In main constructor");
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;
    }
}


class User
{
    public string name;
    public static int number;
    public User(string name)
    {
        this.name = name;
    }
    static User()
    {
        number = Random.Shared.Next();
    }
    public override string ToString()
    {
        return string.Format("Name: {0}, Number: {1}", name, number);
    }
}


class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Speaks in animal");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Speaks in dog.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Speaks in cat.");
    }
}


class Cow : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Speaks in cow.");
    }
}
