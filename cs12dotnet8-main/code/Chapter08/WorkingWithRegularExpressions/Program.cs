using System.Collections;
using System.Text.RegularExpressions; // to use Regex

WriteLine("Enter your age");
string input = ReadLine()!;
Regex ageChecker = DigitsOnly();
WriteLine(ageChecker.IsMatch(input) ? $"{input} is a valid age." : $"{input} is not a valid age.");

string films = """
 "Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
 """;
WriteLine($"Films to split: {films}");
string[] filmsDumb = films.Split(',');
WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"  {film}");
}

//Regex re = new("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
Regex re = CommaSeparator();
MatchCollection m =  re.Matches(films);
WriteLine("Splitting with regular expression:");
foreach (Match film in m)
{
    WriteLine($"  {film.Groups[2].Value}");
}


int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
foreach (int i in a)
{
    Write($"{i} ");
}
WriteLine();

IEnumerator en = a.GetEnumerator();
while(en.MoveNext())
{
    Write($"{en.Current.ToString()} ");
}
WriteLine();
