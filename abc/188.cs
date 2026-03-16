using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folder = "MyFolder";
        string file = Path.Combine(folder, "data.txt");

        if (!Directory.Exists(folder))
            Directory.CreateDirectory(folder);

        File.WriteAllText(file, "Hello Directory & File Handling!");

        string content = File.ReadAllText(file);

        Console.WriteLine("File Content: " + content);
    }
}