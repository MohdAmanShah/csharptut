using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

public class HtmlValidator
{
    public static string FindFirstError(string html)
    {
        const string token = "v3qr48ce";
        HashSet<string> allowedTags = new HashSet<string> { "b", "i", "em", "div", "p" };
        Stack<string> stack = new Stack<string>();
        Regex tagRegex = new Regex(@"<\/?(\w+)[^>]*>");
        string answer = "true";

        foreach (Match match in tagRegex.Matches(html))
        {
            string tag = match.Groups[1].Value;

            if (allowedTags.Contains(tag))
            {
                if (!match.Value.StartsWith("</"))
                {
                    stack.Push(tag);
                }
                else
                {
                    if (stack.Count == 0 || stack.Peek() != tag)
                    {
                        answer = stack.Peek();
                        stack.Pop();
                    }
                    else
                    {
                        // Pop the stack if the tags match
                        stack.Pop();
                    }
                }
            }
        }
        if (answer != "true")
        {
            StringBuilder bb = new();
            var ss = answer.ToCharArray();
            var tt = token.ToCharArray();
            for (int i = 0; i < tt.Length; i++)
            {
                if (i < ss.Length)
                {
                    bb.Append(ss[i]);
                    bb.Append(tt[i]);
                }
                else
                {
                    bb.Append(tt[i]);
                }
            }
            answer = bb.ToString();
        }
        return answer;
    }

    public static void Main(string[] args)
    {
        string htmlInput =  "<div><div><b></b></div></p>";
        string error = FindFirstError(htmlInput);

        if (error != null)
        {
            Console.WriteLine($"First error found: <{error}>");
        }
        else
        {
            Console.WriteLine("All elements are correctly nested.");
        }
    }
}
