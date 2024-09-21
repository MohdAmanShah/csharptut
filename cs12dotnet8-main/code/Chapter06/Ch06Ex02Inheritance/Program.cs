//using Packt.Shared;

//#region OverrideMethod
////Animal dog = new Animal("Oscar", "Gernman Shepherd");
////WriteLine(dog);


////public class Animal
////{
////    public string? Name { get; set; }
////    public string? Species { get; set; }
////    public Animal() { }
////    public Animal(string? name, string? species)
////    {
////        Name = name;
////        Species = species;
////    }
////    public override string ToString()
////    {
////        return $"{Name}, {Species}.";
////    }
////}
//#endregion

//Person Boy = new Person()
//{
//    Name = "Boy",
//    Born = new DateTimeOffset(year: 2001, month: 2, day: 19,
//    hour: 0, minute: 0, second: 0,
//    offset: TimeSpan.Zero)
//};

//Person Girl = new Person()
//{
//    Name = "Girl",
//    Born = new DateTimeOffset(year: 2001, month: 3, day: 19, hour: 0, minute: 0, second: 0, offset: TimeSpan.Zero)
//};
//Boy.WriteToConsole();

//Boy.OutputSpouses();
//Boy.Marry(Girl);

//try
//{
//    Person baby = Boy.ProcreateWith(Girl);
//    Console.WriteLine(baby.Name);
//}
//catch (Exception ex)
//{
//    WriteLine(ex.Message);
//}

//Boy.WriteChildrenToConsole();
//Boy.OutputSpouses();


//Person Emily = new Person(nameof(Emily));
//Person John = new Person(nameof(John));
//Person Lia = new Person(nameof(Lia));


//if (Emily + John)
//{
//    WriteLine($"{John.Name} and {Emily.Name} and married.");
//}

//if (Lia + John)
//{
//    WriteLine($"{John.Name} and {Lia.Name} are married.");
//}

//Person baby2 = Lia * John;
//WriteLine(baby2.Name);

//// can allow any type value to key or value because it Object beneath to store the values and keys.
//// It is insecure, slow and inefficient compared to generics.
//System.Collections.Hashtable lookup = new();
//lookup.Add(key: 1, value: "Aman");
//lookup.Add(key: 2, value: "Noa");
//lookup.Add(key: 3, value: "Mohd");
//lookup.Add(key: "noa", value: "gamertag");

//WriteLine($"Lookup with Key: {1} is {lookup[1]}");
//WriteLine($"Loopup with Key: {"noa"} is {lookup["noa"]}");

//// Using generics Library data type

//Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
//keyValuePairs.Add(1, "Aman");
//keyValuePairs.Add(2, "Noa");
////keyValuePairs.Add("M", "Mohd"); // will cause error by compiler.


//WriteLine($"Dictionary with Key {1} have value {keyValuePairs[1]}");
//WriteLine($"Dictionary with Key {2} have value {keyValuePairs[2]}");


//Person Bob = new Person(nameof(Bob));
//Bob.Shout = Person_Shout;
//Bob.Poke();
//Bob.Poke();
//Bob.Poke();
//Bob.Poke();
//Bob.Poke();

//#region UsingDelegate
//void SayHello(string name)
//{
//    WriteLine($"Hello, {name}");
//}

//void SayBye(string name)
//{
//    WriteLine($"Bye, {name}");
//}
//Interact d;
//d = SayHello;
//d += SayBye;
//d.  Invoke("Aman");



//delegate void Interact(string name);

//#endregion