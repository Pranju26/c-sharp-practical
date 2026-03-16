using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "data.txt";

        File.WriteAllText(path, "Hello File Handling!");

        string content = File.ReadAllText(path);

        Console.WriteLine("File Content: " + content);
    }
}