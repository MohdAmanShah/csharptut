using System.Runtime.CompilerServices;
using FunWithConfiguration;
using Microsoft.Extensions.Configuration;

IConfiguration config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile("appsettings.development.json", true, true)
                        .Build();
Console.WriteLine(config["CarName"]);
Console.WriteLine(config["CarName"] == null);
Console.WriteLine(config.GetValue<string>("CarName"));
try
{
    Console.WriteLine(config.GetValue<int>("CarName"));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(config["Car:Make"]);
Console.WriteLine(config["Car:Colour"]);

IConfigurationSection section = config.GetSection("Car");
Console.WriteLine(section["Name"]);
Console.WriteLine(section["Make"]);

Car c = new Car();
section.Bind(c);
Console.WriteLine(c);


// if section is not found the Bind method don't changes values in class instance passed.
Car d = new Car("Honda", "Peter", "Orange");
config.GetSection("J").Bind(d);
Console.WriteLine(d);

try
{
    Car e = section.Get<Car>(t => t.ErrorOnUnknownConfiguration = true);
    Console.WriteLine(e);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Car f = section.Get(typeof(Car)) as Car;
Console.WriteLine(f);


try
{
    Car g = config.GetRequiredSection("Car2").Get<Car>();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
