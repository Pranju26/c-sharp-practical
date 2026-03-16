using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        for (int i = 0; i < 3000000; i++) { }

        sw.Stop();
        Console.WriteLine("Loop 1 Time: " + sw.ElapsedMilliseconds);

        sw.Restart();

        for (int i = 0; i < 5000000; i++) { }

        sw.Stop();
        Console.WriteLine("Loop 2 Time: " + sw.ElapsedMilliseconds);
    }
}