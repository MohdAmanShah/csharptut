var a = ("aman", 23, "btech", "dakpathar", 22);
Console.WriteLine(a.Item5);

(string Name, int Age, string HighestQualification, string address) user = ("Mohd Aman Shah", 23, "btech", "dakpathar");
Console.WriteLine(user);
Console.WriteLine(user.Item1);


var address = (City: "Vikasnagar", Village: "Ambaari", District: "Dehradun", State: "Uttarakhand", Postal: "248125");
Console.WriteLine(address);
Console.WriteLine(address.Item1);


var User = new
{
    Name = "Aman",
    Age = 23,
};


// Tuple's field names can be infered using Name and Age field of the Object
var userTuple = (User.Name, User.Age);
Console.WriteLine(userTuple);
Console.WriteLine(userTuple.Name);
Console.WriteLine(userTuple.Age);


(int a, int b) intTuple = (122, 32);
(long a, long b) longTuple = (122, 32);
(int a, long b) longSecond = (23, 23);
(long a, int b) longFirst = (23, 23);

Console.WriteLine(intTuple == longTuple);
Console.WriteLine(longFirst == longSecond);

(int a, int b, int c) someTuple = (0, 0, 0);
(int a, (int b, int c)) someMoreTuple = (0, (0, 0));

Console.WriteLine(someTuple);
Console.WriteLine(someMoreTuple);

// To match two tuples for inequality the tuple must have same cardinality.
// The tuples are implicitly matched to check for inequality.

// Console.WriteLine(someTuple == someMoreTuple);

// tuples can also be returned from a method
var returnedFromMethod = ReturnTuple();
Console.WriteLine(returnedFromMethod);


var MyName = ReturnNames();
Console.WriteLine(MyName);


// we can also discard the parts of returned tuple using the discard operator. _
(string firstname, _, string lastname) = ReturnNames();


Console.WriteLine(RockPaperScissor("rock", "paper"));
Console.WriteLine(RockPaperScissor("paper", "rock"));
Console.WriteLine(RockPaperScissor("paper", "paper"));


User aUser = new User();
aUser.Name = "Noa";
aUser.Age = 23;

(string name, int age) var1 = aUser.Deconstruct();
(string name, int age) = aUser.Deconstruct();
(string name1, int age1) = aUser;

Console.WriteLine(var1);
Console.WriteLine(name1);
Console.WriteLine(age1);
Console.WriteLine(name);
Console.WriteLine(age);


Point p1 = new Point
{
    X = -23,
    Y = 11,
};


int x;
int y;

(x, y) = p1;


Console.WriteLine(Quadrunt(p1));
Console.WriteLine(Quadrunt2(p1));