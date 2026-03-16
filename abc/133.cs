using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LAMBDA EXPRESSIONS DEMO ===");

        List<int> nums = new List<int> { 10, 25, 3, 40, 15, 7 };

        var even = nums.Where(x => x % 2 == 0).ToList();
        var square = nums.Select(x => x * x).ToList();
        var sorted = nums.OrderBy(x => x).ToList();

        Console.WriteLine("\nEven numbers:");
        even.ForEach(x => Console.Write(x + " "));

        Console.WriteLine("\n\nSquares:");
        square.ForEach(x => Console.Write(x + " "));

        Console.WriteLine("\n\nSorted:");
        sorted.ForEach(x => Console.Write(x + " "));
    }
}