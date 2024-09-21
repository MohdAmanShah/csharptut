using Packt.Shared;
//int thisCannotBeNull = 5;
////thisCannotBeNull = null;
//WriteLine(thisCannotBeNull);

//int? thisCanBeNull = 5;
//thisCanBeNull = null;

//WriteLine(thisCanBeNull);
//WriteLine(thisCanBeNull.GetValueOrDefault());

//thisCanBeNull = 7;
//WriteLine(thisCanBeNull);
//WriteLine(thisCanBeNull.GetValueOrDefault());
Address permanent = new Address(city:"VikasNagar")
{
    Building = null,
    Region = null!,
    Street = "Near Dakpathar Bus Stand"
};
WriteLine(permanent);

public class Address
{
    public string? Building;
    public string Street = String.Empty;
    public string City;
    public string Region;
    public Address()
    {
        City = String.Empty;
        Region = String.Empty;
    }
    public Address(string city) : this()
    {
        City = city;
    }
    public override string ToString()
    {
        return $"{Building},{Street},{City},{Region}";
    }
}



