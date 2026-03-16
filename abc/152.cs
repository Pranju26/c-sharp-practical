using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "sample.txt";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Hello from using statement!");
        }

        Console.WriteLine("File written successfully using IDisposable!");
    }
}