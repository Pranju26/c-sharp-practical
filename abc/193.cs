using System;
using System.Text.Json;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student { Name = "Rohan", Marks = 89 };

        string json = JsonSerializer.Serialize(s, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        Console.WriteLine(json);
    }
}