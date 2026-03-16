using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        var task = Task.Run(() =>
        {
            for (int i = 1; i <= 10; i++)
            {
                if (cts.Token.IsCancellationRequested)
                {
                    Console.WriteLine("Task Cancelled!");
                    return;
                }
                Console.WriteLine("Working... " + i);
                Thread.Sleep(500);
            }
        });

        Console.WriteLine("Press Enter to Cancel");
        Console.ReadLine();
        cts.Cancel();

        await task;
        Console.WriteLine("Program Completed");
    }
}f