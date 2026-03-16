using System;

class Person
{
    private int age;
    public int Age
    {
        get => age;
        set => age = value;
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = 25;
        Console.WriteLine(p.Age);
    }
}