using System;

class Program
{
    static void Main()
    {
        int[] data = new int[1000000];
        for (int i = 0; i < data.Length; i++)
            data[i] = i;

        long sum = 0;

        // optimized loop (cache-friendly)
        for (int i = 0; i < data.Length; i++)
            sum += data[i];

        Console.WriteLine("Sum = " + sum);
    }
}