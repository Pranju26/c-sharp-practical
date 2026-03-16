using System;

class Program
{
    static void Main()
    {
        int? age = null;

        Console.WriteLine("Age: " + (age ?? 0));

        age = 25;

        Console.WriteLine("Age after update: " + age.Value);
    }
}