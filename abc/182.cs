using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Cat, Dog, Cow, Lion, Tiger";
        string pattern = @"\b\w{3}\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("All 3-letter words:");
        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}