using System;

class Program
{
    static void Main()
    {
        string sentence = "C# is a powerful language";

        string[] words = sentence.Split(' ');

        Console.WriteLine("Words:");
        foreach (var w in words)
            Console.WriteLine(w);

        string joined = string.Join("-", words);
        Console.WriteLine("Joined: " + joined);
    }
}