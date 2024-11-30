FileInfo f = new FileInfo("BinFile.dat");
// using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
// {
//     double aDouble = 123.45;
//     int anInt = 234;
//     string aString = "Abc";

//     bw.Write(aDouble);
//     bw.Write(anInt);
//     bw.Write(aString);
// }
// Console.WriteLine("Done");

using(BinaryReader br = new BinaryReader(f.OpenRead()))
{
    Console.WriteLine(br.ReadDouble());
    Console.WriteLine(br.ReadInt32());
    Console.WriteLine(br.ReadString());w
}

