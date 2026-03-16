using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sentence = "This is a simple example of stop word removal in C sharp";

        string[] stopWords = { "is", "a", "of", "in" };

        var filteredWords = sentence
            .Split(' ')
            .Where(word => !stopWords.Contains(word));

        Console.WriteLine("Filtered Sentence:");
        Console.WriteLine(string.Join(" ", filteredWords));
    }
}