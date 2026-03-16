using System;

class Program
{
    static (int Id, string Name, int Marks) GetStudent()
    {
        return (1, "Rohan", 89);
    }

    static void Main()
    {
        var s = GetStudent();
        Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
    }
}