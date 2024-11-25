using System.Net;
using System.Text;

string _theEBook = "";
GetBook();
Console.WriteLine("Downloading ebook");
Console.ReadKey();

void GetBook()
{
    using WebClient wc = new WebClient();
    wc.DownloadStringCompleted += (s, e) =>
    {
        Console.WriteLine("File Downloaded");
        _theEBook = e.Result;
        GetStats();
    };
    wc.DownloadStringAsync(new Uri("http://www.gutenberg.org/files/98/98-0.txt"));
}

void GetStats()
{
    string[] words = _theEBook.Split(new char[]{
    ' ', '\u000a', ',','.',';',':','-','?','/'}, StringSplitOptions.RemoveEmptyEntries);
    string[] tenMostCommonEntries = null;
    string longestWord = "";
    System.Threading.Tasks.Parallel.Invoke(() =>
    {
        tenMostCommonEntries = GetMostCommonEntries(words);
    },
    () =>
    {
        longestWord = GetLongestWord(words);
    });
    StringBuilder result = new StringBuilder("Ten Most Common Words are: \n");
    foreach (string t in tenMostCommonEntries)
    {
        result.AppendLine(t);
    }
    result.AppendFormat("Longest Word is : {0}", longestWord);

    Console.WriteLine(result.ToString(), "Book Info");
}

string[] GetMostCommonEntries(string[] words)
{
    var entries = from word in words
                  where word.Length > 6
                  group word by word into g
                  orderby g.Count() descending
                  select g.Key;
    return entries.Take(10).ToArray();
}

string GetLongestWord(string[] words)
{
    return (from word in words orderby word.Length descending select word).FirstOrDefault();
}