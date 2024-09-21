int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0; i < array.Length; i++)
{
    Index idx = i;
    Console.Write(array[idx] + " ");
}
Console.WriteLine();
for (int i = 1; i <= array.Length; i++)
{
    Index idx = ^i;
    Console.Write(array[idx] + " ");
}
Console.WriteLine();
foreach (int i in array[0..5])
{
    Console.Write(i);
    Console.Write(" ");
}
Console.WriteLine();










void ArrayClassUses()
{
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

    Console.WriteLine(gothicBands.ToFormattedString());

    gothicBands = gothicBands.Reverse().ToArray();

    Console.WriteLine(gothicBands.ToFormattedString());

    Array.Reverse(gothicBands);

    Console.WriteLine(gothicBands.ToFormattedString());

    Array.Clear(gothicBands, 1, 2);

    Console.WriteLine(gothicBands.ToFormattedString());

    Console.WriteLine(gothicBands.Length);

}

public static class Extensions
{
    public static string ToFormattedString(this Array array)
    {
        return String.Join(", ", array.Cast<string>().ToArray());
    }
}