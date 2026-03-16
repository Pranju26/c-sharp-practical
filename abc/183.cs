using System;

class Program
{
    delegate void Callback(string msg);

    static void ProcessTask(Callback cb)
    {
        Console.WriteLine("Task Processing...");
        cb("Task Completed Successfully!");
    }

    static void Main()
    {
        Callback c = message => Console.WriteLine(message);

        ProcessTask(c);
    }
}