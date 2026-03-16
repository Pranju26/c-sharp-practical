using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<int> GenerateNumbers()
    {
        yield return 10;
        yield return 20;
        yield return 30;
        yield return 40;
    }

    static void Main()
    {
        foreach (var n in GenerateNumbers())
            Console.WriteLine(n);
    }
}