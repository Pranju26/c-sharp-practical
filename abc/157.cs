using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 20);

        var result = numbers
            .AsParallel()
            .Where(n => n % 2 == 0)
            .Select(n => n * n);

        Console.WriteLine("PLINQ Results:");
        foreach (var v in result)
            Console.WriteLine(v);
    }
}