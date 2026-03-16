using System;

class Student
{
    public string Name;
    public void Show() => Console.WriteLine("Student Name: " + Name);
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Rahul";
        s.Show();
    }
}