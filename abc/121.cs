using System;

class AgeException : Exception
{
    public AgeException(string msg) : base(msg) { }
}

class Program
{
    static void Main()
    {
        int age = 15;

        if (age < 18)
            throw new AgeException("Age must be 18+");

        Console.WriteLine("Welcome!");
    }
}