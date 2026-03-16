using System;

class Person
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Person p = null;

        Console.WriteLine("Name: " + (p?.Name ?? "Unknown"));

        p = new Person { Name = "Rohan" };
        Console.WriteLine("Updated Name: " + (p?.Name ?? "Unknown"));
    }
}