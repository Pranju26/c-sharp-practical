using System;
using System.Linq;
using System.Collections.Generic;

class Student
{
    public int DeptId;
    public string Name;
}

class Department
{
    public int DeptId;
    public string DeptName;
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Department> departments = new List<Department>();

        Console.WriteLine("=== LINQ JOIN DEMO ===\n");

        Console.Write("How many students? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student s = new Student();

            Console.Write("\nEnter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Department ID: ");
            s.DeptId = int.Parse(Console.ReadLine());

            students.Add(s);
        }

        // Hardcoded or input-based departments
        departments.Add(new Department { DeptId = 1, DeptName = "Computer Science" });
        departments.Add(new Department { DeptId = 2, DeptName = "Mechanical" });
        departments.Add(new Department { DeptId = 3, DeptName = "Electrical" });

        var joinQuery = from s in students
                        join d in departments
                        on s.DeptId equals d.DeptId
                        select new
                        {
                            StudentName = s.Name,
                            Department = d.DeptName
                        };

        Console.WriteLine("\n--- JOIN RESULT ---");
        foreach (var item in joinQuery)
            Console.WriteLine(item.StudentName + " - " + item.Department);
    }
}