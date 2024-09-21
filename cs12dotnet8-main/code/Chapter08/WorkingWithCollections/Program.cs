using System.Collections.Immutable; // To use ImmutableDictionary
using System.Collections.Frozen; // To use FrozenDictionary
using StringDictionary = System.Collections.Generic.Dictionary<string, string>;

//List<String> cities = new();
//cities.Add("London");
//cities.Add("Paris");
//cities.Add("Milan");
//OutputCollection("Initial list", cities);
//WriteLine($"The first city is {cities[0]}.");
//WriteLine($"The last city is {cities[cities.Count - 1]}.");


//cities.Insert(0, "Sydney");
//OutputCollection("After inserting Sydney at index 0", cities);

//cities.RemoveAt(1);
//cities.Remove("Milan");
//OutputCollection("After removing two cities", cities);

//StringDictionary keywords = new StringDictionary();
//keywords.Add("RSA", "A hasing algorithm");
//keywords.Add("DES", "Data Encryption Standard");
//keywords.Add("AES", "Advanced Encryption Standard");


//OutputCollection("Dictionary Keys", keywords.Keys);
//OutputCollection("Dictionary values", keywords.Values);

//WriteLine("Keywords and their definitions:");
//foreach (KeyValuePair<string, string> item in keywords)
//{
//    WriteLine($" {item.Key}:{item.Value}");
//}
//string key = "long";
//try
//{
//    WriteLine($"The definition of {key} is {keywords[key]}.");
//}
//catch (Exception e)
//{
//    WriteLine(e.Message);
//}

//key = "DES";

//WriteLine($"The definition of {key} is {keywords[key]}");

//UseDictionary(keywords.AsReadOnly());
//UseDictionary(keywords.ToImmutableDictionary());

//ImmutableDictionary<string, string> immutableKeyword = keywords.ToImmutableDictionary();

//ImmutableDictionary<string, string> newDictionary = immutableKeyword.Add(
//    key: Guid.NewGuid().ToString(),
//   value: Guid.NewGuid().ToString());

//OutputCollection("Immutable Keywords", immutableKeyword);
//OutputCollection("New Keywords", newDictionary);

//FrozenDictionary<string, string> frozenKeywords = keywords.ToFrozenDictionary();

//OutputCollection("Frozen keywords", frozenKeywords);

//// Lookups are faster in a frozen dictionary.
//WriteLine($"Define RSA: {frozenKeywords["RSA"]}");

//HashSet<string> names = new();

//foreach (string name in new[] { "Adam", "Barry", "Charlie", "Barry" })
//{
//    bool added = names.Add(name);
//    WriteLine($"{name} was added: {added}");
//}

//names.WriteToConsole();

//public static class ExtensionMethods
//{
//    public static void WriteToConsole(this HashSet<string> names)
//    {
//        WriteLine($"Set: {String.Join(",", names)}.");
//    }
//}

//Queue<string> coffee = new();
//coffee.Enqueue("Damir");
//coffee.Enqueue("Andrea");
//coffee.Enqueue("Ronald");
//coffee.Enqueue("Amin");
//coffee.Enqueue("Irina");

//OutputCollection("Initial queue from front to back", coffee);

//string served = coffee.Dequeue();
//WriteLine($"Served : {served}");

//served = coffee.Dequeue();
//WriteLine($"Server: {served}");
//OutputCollection("Current queue from front to back", coffee);

//WriteLine($"{coffee.Peek()} is next in line");
//OutputCollection("Current queue from front to back", coffee);

//PriorityQueue<string, int> vaccine = new();

//vaccine.Enqueue("Pamela", 1);
//vaccine.Enqueue("Rebecca", 3);
//vaccine.Enqueue("Juliet", 2);
//vaccine.Enqueue("Ian", 1);

//OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

//WriteLine($"{vaccine.Dequeue()} has been vaccinated.");
//WriteLine($"{vaccine.Dequeue()} has been vaccinated.");

//OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

//WriteLine($"{vaccine.Dequeue()} has been vacinated.");

//vaccine.Enqueue("Mark", 2);

//WriteLine($"{vaccine.Peek()} will be next to be vaccinated.");
//OutputPQ("Current queue for vaccination", vaccine.UnorderedItems);

//List<int> list = new List<int>();
//list.Add(1);
//list.Add(2);
//list.Add(3);
//list.Add(4);
//WriteLine(list.IndexOf(3));

int[] array = [1, 2, 3, 4];
List<int> list = [1, 2, 3, 4];
Span<int> span = [1, 2, 3, 4];

//OutputCollection("int array:", array);
//OutputCollection("list of int", list);

//Index i = new Index(3, fromEnd:true);
//WriteLine(array[i]);

foreach(int i in span)
{
    WriteLine(i);
}
