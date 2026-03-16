using System;
using System.Collections;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}

class SortByMarks : IComparer<Student>
{
    public int Compare(Student s1, Student s2)
    {
        return s1.Marks.CompareTo(s2.Marks);
    }
}

class Program
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student { Name = "Rohan", Marks = 88 },
            new Student { Name = "Neha", Marks = 92 },
            new Student { Name = "Amit", Marks = 79 }
        };

        list.Sort(new SortByMarks());

        foreach (var s in list)
            Console.WriteLine($"{s.Name} : {s.Marks}");
    }
}