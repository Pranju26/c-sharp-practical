using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task t1 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine("Task 1: " + i);
        });

        Task t2 = Task.Run(() =>
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine("Task 2: " + i);
        });

        Task.WaitAll(t1, t2);
        Console.WriteLine("All Tasks Completed");
    }
}