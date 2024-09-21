partial class Program
{
    private static void SectionTitle(string title)
    {
        ConsoleColor color = ForegroundColor;
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"***{title}***");
        ForegroundColor = color;
    }

    private static void OutputFileInfo(string filepath)
    {
        WriteLine(
@$"***File Info***
File: {GetFileName(filepath)}
Path: {GetDirectoryName(filepath)}
Length: {new FileInfo(filepath).Length:N0} bytes.
----------------------------------------------
{File.ReadAllText(filepath)}
----------------------------------------------"
);
    }
}