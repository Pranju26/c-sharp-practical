using System;

class Program
{
    static (int, string) GetData()
    {
        return (101, "Rahul");
    }

    static void Main()
    {
        var data = GetData();
        Console.WriteLine("ID: " + data.Item1);
        Console.WriteLine("Name: " + data.Item2);
    }
}