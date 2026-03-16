using System;

public record Student(string Name, int Age);

class Program
{
    static void Main()
    {
        Student s1 = new Student("Rahul", 21);
        Student s2 = s1 with { Name = "Rohan" };

        Console.WriteLine("Student 1: " + s1);
        Console.WriteLine("Student 2: " + s2);
    }
}