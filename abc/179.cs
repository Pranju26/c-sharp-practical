using System;

class AgeException : Exception
{
    public int AgeValue { get; }

    public AgeException(string msg, int age) : base(msg)
    {
        AgeValue = age;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 18)
        {
            throw new AgeException("Age must be 18+", age);
        }

        Console.WriteLine("Valid Age: " + age);
    }
}