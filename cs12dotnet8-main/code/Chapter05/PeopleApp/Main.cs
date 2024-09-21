using Packt.Shared;
using System.Text.Json;
using Env = System.Environment;

ConfigureConsole();

Person Bob = new Person();
Bob.Name = "Bob";

Person Alfred = new Person();
Alfred.Name = "Alfred";

Bob.Children.Add(Alfred);
Bob.Children.Add(new Person(initialName: "Bella", homePlanet: "Earth"));
Bob.Children.Add(new(initialName: "Price", homePlanet: "Earth"));
Bob.Children.Add(new Person { Name = "John" });
Bob.Children.Add(new() { Name = "Soap" });

Console.WriteLine($"{Bob.Name} has {Bob.Children.Count} children.");

//for(int i =0; i < Bob.Children.Count; i++)
//{
//    Console.WriteLine($"> {Bob.Children[i].Name}");
//}

foreach (Person person in Bob.Children)
{
    Console.WriteLine($"> {person.Name} from {person.HomePlanet}");
}

BankAccount.InterestRate = 0.1M;
BankAccount JonesAccount = new BankAccount();
JonesAccount.AccountName = "Mr. Jones";
BankAccount SoapAccount = new BankAccount { AccountName = "Mr. Soap" };


// Can access the static field using Class name only.
WriteLine($"{JonesAccount.AccountName} have interest rate of {BankAccount.InterestRate}");
WriteLine($"{SoapAccount.AccountName} have interest rate of {BankAccount.InterestRate}");

// Can access  the const Field using the Class name only
WriteLine($"{Bob.Name} is a {Person.Species}");


Book book = new()
{
    Isbn = "978-1293-1244",
    Title = "The book"
};




var recordOne = (Bob.Name, Bob.HomePlanet);

WriteLine($"{recordOne.Name} is from {recordOne.HomePlanet}");
WriteLine(recordOne.GetType().Name);


WriteLine(Env.GetFolderPath(Env.SpecialFolder.DesktopDirectory));


(string fruit, int number) = Bob.GetFruit();
WriteLine($"Decontructed tuples {fruit} and {number}");

(string fruit, int number) data = Bob.GetFruit();
WriteLine(data);


var (name1, dob1) = Bob;
var (name2, dob2, fav2) = Bob;

WriteLine($"{name1} and {dob1}");
WriteLine($"{name2}, {dob2}, and {fav2}");

int Nu = -1;
try
{
    WriteLine($"{Nu}! is {Person.Factorial(Nu)}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}



WriteLine(Bob.Origin);
WriteLine(Bob.Greeting);
WriteLine(Bob.Age);


string color = "red";
try
{
    Bob.FavoritePrimaryColor = color;
    WriteLine(Bob.FavoritePrimaryColor);
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}


try
{
    //Bob.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.HangingGardensOfBabylon;
    Bob.FavoriteAncientWonder = (WondersOfTheAncientWorld)128;
    WriteLine($"{Bob.Name} favorite ancient wonder is {Bob.FavoriteAncientWonder}");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType().Name}: {ex.Message}");
}



WriteLine(Bob.Children.Count);

WriteLine(Bob[1]);
WriteLine(Bob["Bella"].HomePlanet);

ImmutableVehicle car = new ImmutableVehicle()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car with
{
    Color = "Polymetal Grey Metallic"
};

WriteLine($"{car.Color} colored {car.Brand} with {car.Wheels} wheels.");
WriteLine($"{repaintedCar.Color} colored {repaintedCar.Brand} with {repaintedCar.Wheels} wheels.");


AnimalClass dog = new AnimalClass()
{
    Name = "Dog",
};

AnimalClass dogg = new AnimalClass()
{
    Name = "Dog"
};

WriteLine($"dog == dogg: {dog == dogg}");

AnimalRecord cat = new AnimalRecord() { Name = "Cat" };
AnimalRecord catt = new AnimalRecord() { Name = "Cat" };

WriteLine($"cat == catt: {cat == catt}");


var (brand, color_) = car;
WriteLine($"{brand} of {color_} color is coming to the town.");


ImmutableAnimal oscar = new ImmutableAnimal("Oscar", "German Shepherd");
var (who,what)

