using System.Formats.Asn1;
using System.Runtime.InteropServices;

using (StreamWriter writer = File.CreateText("Text.dat"))
{
    writer.WriteLine("abcd");
    writer.WriteLine("efgh");
    writer.Write(writer.NewLine);
}

using (StreamReader reader = File.OpenText("Text.dat"))
{
    Console.WriteLine(reader.ReadToEnd());  
}