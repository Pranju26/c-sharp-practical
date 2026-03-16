using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("=== LINQ (Where, Select) DEMO ===\n");
        Console.Write("How many numbers to add? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nNumbers entered:");
        numbers.ForEach(x => Console.Write(x + " "));

        var even = numbers.Where(x => x % 2 == 0).ToList();
        var squares = numbers.Select(x => x * x).ToList();

        Console.WriteLine("\n\n--- Even Numbers (WHERE) ---");
        even.ForEach(x => Console.Write(x + " "));

        Console.WriteLine("\n\n--- Squares (SELECT) ---");
        squares.ForEach(x => Console.Write(x + " "));

        Console.WriteLine("\n");
    }
}