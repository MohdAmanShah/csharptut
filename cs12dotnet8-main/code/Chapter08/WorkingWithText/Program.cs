using System.Globalization; // to use Culture info.
OutputEncoding = System.Text.Encoding.UTF8;

string Name = "mohammed aman shah";
WriteLine($"{Name} is {Name.Length} characters long");

string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
string[] citiesSeperated = cities.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string city in citiesSeperated)
{
    WriteLine(city);
}

WriteLine(Name.Substring(0, 8));
WriteLine(Name.Substring(9, 4));
WriteLine(Name.Substring(14));

string n1 = "aman";
string n2 = "AMAN";


WriteLine(string.Compare(n1, n2));
WriteLine(string.Compare(n1, n2, ignoreCase: true));
WriteLine(string.Compare(n1, n2, StringComparison.InvariantCultureIgnoreCase));


string combined = String.Join(" => ", citiesSeperated);

WriteLine(combined);