using System.Text.RegularExpressions; // To use Regex

partial class Program
{
    [GeneratedRegex(DigitsOnlyText,RegexOptions.IgnoreCase)]
    private static partial Regex DigitsOnly();

    [GeneratedRegex(CommaSeparatorText, RegexOptions.IgnoreCase)]
    private static partial Regex CommaSeparator();
}