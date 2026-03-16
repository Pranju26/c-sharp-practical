using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("sample.txt"))
        {
            sw.WriteLine("This is written using IDisposable pattern.");
        }

        Console.WriteLine("File created successfully!");
    }
}