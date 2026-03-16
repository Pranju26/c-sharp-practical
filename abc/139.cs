using System;

static class StringExtensions
{
    public static int WordCount(this string str)
    {
        return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

class Program
{
    static void Main()
    {
        string sentence = "Welcome to extension methods in C Sharp";

        Console.WriteLine("Word Count = " + sentence.WordCount());
    }
}