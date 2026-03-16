using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main Thread Started");

        for (int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(DoWork, i);
        }

        Console.WriteLine("Main Thread Completed");
        Console.ReadLine();
    }

    static void DoWork(object state)
    {
        int num = (int)state;
        Console.WriteLine("Task " + num + " started on thread " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(1000);
        Console.WriteLine("Task " + num + " finished");
    }
}