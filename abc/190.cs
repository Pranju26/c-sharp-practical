using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        Task task = Task.Run(() =>
        {
            int i = 1;
            while (!cts.Token.IsCancellationRequested)
            {
                Console.WriteLine("Working... " + i++);
                Thread.Sleep(500);
            }
        });

        Console.WriteLine("Press ENTER to stop...");
        Console.ReadLine();

        cts.Cancel();
        await task;

        Console.WriteLine("Task stopped successfully!");
    }
}