using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= 10; i++)
            numbers.Add(i);

        Parallel.ForEach(numbers, n =>
        {
            Console.WriteLine("Processing " + n + " on Thread: " + Task.CurrentId);
        });

        Console.WriteLine("Parallel.ForEach Completed");
    }
}