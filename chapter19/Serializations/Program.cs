global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Xml;
global using System.Xml.Serialization;





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

SaveAsXMLDocument(myCars, "myCars.xml");
SaveAsXMLDocument(p, "person.xml");

static void SaveAsXMLDocument<T>(T objectGraph, string fileName)
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
    using (Stream stream = File.Open(fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
        xmlSerializer.Serialize(stream, objectGraph);
    }
}

public class Radio
{
    public bool HasTweeters;
    public bool HasSubWoofers;
    public List<double> StationPresets;
    public string RadioId = "XF-552RR6";
    public override string ToString()
    {
        var presets = string.Join(",", StationPresets.Select(i => i.ToString()).ToList());
        return $"HasTweeters:{HasTweeters} HasSubWoofers:{HasSubWoofers} Station Presets:{presets}";
    }
}

public class Car
{
    public Radio TheRadio = new Radio();
    public bool IsHatchBack;
    public override string ToString()
    => $"IsHatchback:{IsHatchBack} Radio:{TheRadio.ToString()}";
}


public class JamesBondCar : Car
{
    [XmlAttribute]
    public bool CanFly;
    [XmlAttribute]
    public bool CanSubmerge;
    public override string ToString()
    => $"CanFly:{CanFly}, CanSubmerge:{CanSubmerge} {base.ToString()}";
}


public class Person
{
    // A public field.
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