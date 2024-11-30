global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Xml;
global using System.Xml.Serialization;
using System.IO.Enumeration;



Human h1 = new Human() { Name = "John" };
Human h2 = new Human() { Name = "Rock" };
h1.Friend = h2;
h2.Friend = h1;

SaveAsJSONDocument(h1, "human.json");

var theRadio = new Radio
{
    StationPresets = new() { 89.3, 105.1, 97.1 },
    HasTweeters = true
};
// Make a JamesBondCar and set state.
JamesBondCar jbc = new()
{
    CanFly = true,
    CanSubmerge = false,
    TheRadio = new()
    {
        StationPresets = new() { 89.3, 105.1, 97.1 },
        HasTweeters = true
    }
};

List<JamesBondCar> myCars = new()
{
new JamesBondCar { CanFly = true, CanSubmerge = true, TheRadio = theRadio },
new JamesBondCar { CanFly = true, CanSubmerge = false, TheRadio = theRadio },
new JamesBondCar { CanFly = false, CanSubmerge = true, TheRadio = theRadio },
new JamesBondCar { CanFly = false, CanSubmerge = false, TheRadio = theRadio },
};


Person p = new Person
{
    FirstName = "James",
    IsAlive = true
};

// SaveAsXMLDocument(myCars, "myCars.xml");
// SaveAsXMLDocument(p, "person.xml");
// Person s = ReadXML<Person>("person.xml");
// List<JamesBondCar> cars = ReadXML<List<JamesBondCar>>("myCars.xml");
// foreach (var car in cars)
// {
//     Console.WriteLine(car);
// }
// SaveAsJSONDocument(myCars, "myCar.json");
// SaveAsJSONDocument(p, "person.json");
// Person h = ReadJSONDocument<Person>("person.json");
// Console.WriteLine(h);
await SerializeAsync();
Console.ReadKey();
async static Task SerializeAsync()
{
    using Stream stream = Console.OpenStandardInput();
    var data = new { Data = PrintNumbers(3) };
    await JsonSerializer.SerializeAsync(stream, data);
}

static async IAsyncEnumerable<int> PrintNumbers(int n)
{
    for (int i = 0; i < n; i++)
    {
        yield return i;
    }
}

static T ReadJSONDocument<T>(string fileName)
{
    using Stream stream = File.OpenRead(fileName);
    JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
    {
        PropertyNamingPolicy = null
    };
    T obj = JsonSerializer.Deserialize<T>(stream, jsonSerializerOptions);
    return obj;
}
static void SaveAsJSONDocument<T>(T objectGraph, string fileName)
{
    JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions()
    {
        IncludeFields = true,
        WriteIndented = true,
        ReferenceHandler = ReferenceHandler.Preserve
        // PropertyNamingPolicy = null
    };
    File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objectGraph, jsonSerializerOptions));
}
static void SaveAsXMLDocument<T>(T objectGraph, string fileName)
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
    using (Stream stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
        xmlSerializer.Serialize(stream, objectGraph);
    }
}

static T ReadXML<T>(string fileName)
{
    XmlSerializer serializer = new XmlSerializer(typeof(T));
    using FileStream fs = File.OpenRead(fileName);
    T obj = (T)serializer.Deserialize(fs);
    return obj;
}
public class Radio
{
    [JsonInclude]
    [JsonPropertyOrder(1)]
    public bool HasTweeters;
    [JsonInclude]
    public bool HasSubWoofers;
    [JsonInclude]
    public List<double> StationPresets;
    [JsonInclude]
    public string RadioId = "XF-552RR6";
    public override string ToString()
    {
        var presets = string.Join(",", StationPresets.Select(i => i.ToString()).ToList());
        return $"HasTweeters:{HasTweeters} HasSubWoofers:{HasSubWoofers} Station Presets:{presets}";
    }
}

public class Car
{
    [JsonInclude]
    public Radio TheRadio = new Radio();
    [JsonInclude]
    public bool IsHatchBack;
    public override string ToString()
    => $"IsHatchback:{IsHatchBack} Radio:{TheRadio.ToString()}";
}


public class JamesBondCar : Car
{
    [JsonInclude]
    public bool CanFly;
    [JsonInclude]
    public bool CanSubmerge;
    public override string ToString()
    => $"CanFly:{CanFly}, CanSubmerge:{CanSubmerge} {base.ToString()}";
}


public class Person
{
    // A public field.
    [JsonInclude]
    public bool IsAlive = true;
    // A private field.
    private int PersonAge = 21;
    // Public property/private data.
    private string _fName = string.Empty;

    public string FirstName
    {
        get { return _fName; }
        set { _fName = value; }
    }
    public override string ToString() =>
    $"IsAlive:{IsAlive} FirstName:{FirstName} Age:{PersonAge} ";
}

public class Human
{
    public string Name { get; set; }
    public Human Friend { get; set; }
}

