using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "My phone number is 9876543210";

        string pattern = @"\d{10}";

        Match match = Regex.Match(text, pattern);

        if (match.Success)
        {
            Console.WriteLine("Phone Number Found: " + match.Value);
        }
        else
        {
            Console.WriteLine("No Number Found");
        }
    }
}