//using System.Numerics; // to use bigInteger
//ulong lb = ulong.MaxValue;
//WriteLine($"{lb}");

//BigInteger bi = BigInteger.Parse("123456789012345678901234567890");
//WriteLine($"{bi}");


//Complex c1 = new Complex(real: 4, imaginary: 5);
//Complex c2 = new Complex(real: 8, imaginary: 1);
//Complex c3 = c1 + c2;
//WriteLine(c3.ToString());


//Random r = Random.Shared;
//WriteLine(r.Next(minValue: 123, maxValue: 22324));
//WriteLine(r.NextDouble());

//byte[] arrayOfBytes = new byte[256];
//r.NextBytes(arrayOfBytes);
//for (int i = 0; i < arrayOfBytes.Length; i++)
//{
//    WriteLine($"{arrayOfBytes[i]:X2}");
//}

//WriteLine();


//string[] Names = new[] { "Johnty", "Sachin", "Peterson", "Bradman", "McGrath" };
//string[] team = r.GetItems(choices: Names, length: 4);
//foreach (string player in team)
//{
//    WriteLine(player);
//}
//WriteLine();

//r.Shuffle(team);

//foreach (string player in team)
//{
//    WriteLine(player);
//}



WriteLine(Guid.Empty);
Guid g = Guid.NewGuid();
WriteLine(g);

byte[] b = g.ToByteArray();
foreach(byte b2 in b)
{
    Write($"{b2:X2} ");
}