// A string array is a sequence that implements IEnumerable<string>.
string[] names = { "Michael", "Pam", "Jim", "Dwight",
  "Angela", "Kevin", "Toby", "Creed", "Antony", "Ambers" };

//DeferredExecution(names);
//FilteringUsingWhere(names);
//FilteringByType();
//WorkingWithSets();

//var query = names
//    .Where(name => name.Length > 4)
//    .OrderBy(name => name.Length)
//    .ThenBy(name => name);

var query = from name in names
            where name.Length > 4
            orderby name.Length, name
            select name;

foreach(string name in query)
{
    WriteLine(name);
}