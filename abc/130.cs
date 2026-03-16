using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public string Department;
}

class Program
{
    static void Main()
    {
        List<Student> list = new List<Student>();

        Console.WriteLine("=== LINQ GroupBy DEMO ===\n");
        Console.Write("How many students to add? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.Write("\nEnter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            s.Department = Console.ReadLine();

            list.Add(s);
        }

        var groups = list.GroupBy(s => s.Department);

        Console.WriteLine("\n--- Grouped Students ---");
        foreach (var group in groups)
        {
            Console.WriteLine("\nDepartment: " + group.Key);
            foreach (var s in group)
                Console.WriteLine(" - " + s.Name);
        }
    }
}