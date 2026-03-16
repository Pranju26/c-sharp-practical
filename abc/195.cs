using System;

class Program
{
    static void Main()
    {
        int[] arr = { 40, 10, 30, 50, 20 };

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");
        foreach (var n in arr)
            Console.WriteLine(n);
    }
}