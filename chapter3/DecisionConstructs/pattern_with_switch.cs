object lang = Console.ReadLine();
var choice = int.TryParse(lang.ToString(), out int c) ? c : lang;
switch (choice)
{
    case int i:
        //do something
        break;
    case int i when i == 0:
        //do something
        break;
    case int i when i == -1:
        // do something
        break;
    case string i:
        Console.WriteLine(i);
        break;
}