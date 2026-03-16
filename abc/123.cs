using System;

class Program
{
    static void Main()
    {
        int num = -5;

        if (num < 0)
            throw new Exception("Number cannot be negative");

        Console.WriteLine(num);
    }
}