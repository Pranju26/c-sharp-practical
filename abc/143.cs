using System;
using System.Threading;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread: " + i);
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread t = new Thread(PrintNumbers);
        t.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main: " + i);
        }
    }
}