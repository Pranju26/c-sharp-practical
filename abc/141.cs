using System;

class Student
{
    public string Name { get; set; }
}

class GenericClass<T> where T : class, new()
{
    public T Create()
    {
        return new T();
    }
}

class Program
{
    static void Main()
    {
        GenericClass<Student> gc = new GenericClass<Student>();
        Student s = gc.Create();
        s.Name = "Rahul";
        Console.WriteLine("Student: " + s.Name);
    }
}