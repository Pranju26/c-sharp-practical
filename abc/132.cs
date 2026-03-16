using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("=== LINQ AGGREGATE DEMO ===");
        Console.Write("How many numbers? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nSum: " + numbers.Sum());
        Console.WriteLine("Min: " + numbers.Min());
        Console.WriteLine("Max: " + numbers.Max());
        Console.WriteLine("Average: " + numbers.Average());

        // Custom aggregate
        int factorial = numbers.Aggregate(1, (acc, x) => acc * x);
        Console.WriteLine("Custom Aggregate (Multiplication): " + factorial);
    }
}