using System;

delegate int MyDelegate(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;
    static int Sub(int a, int b) => a - b;

    static void Main()
    {
        Console.WriteLine("=== DELEGATES DEMO ===\n");
        MyDelegate del;

        Console.Write("Enter number 1: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("\nUsing Add:");
        del = Add;
        Console.WriteLine("Result: " + del(x, y));

        Console.WriteLine("\nUsing Sub:");
        del = Sub;
        Console.WriteLine("Result: " + del(x, y));
    }
}