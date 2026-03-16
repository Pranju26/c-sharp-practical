using System;

delegate void MyDelegate();

class Program
{
    static void Method1() => Console.WriteLine("Method 1 executed.");
    static void Method2() => Console.WriteLine("Method 2 executed.");
    static void Method3() => Console.WriteLine("Method 3 executed.");

    static void Main()
    {
        Console.WriteLine("=== MULTICAST DELEGATE DEMO ===\n");

        MyDelegate del = null;

        del += Method1;
        del += Method2;
        del += Method3;

        Console.WriteLine("Calling delegate...");
        del();

        del -= Method2;

        Console.WriteLine("\nAfter removing Method2:");
        del();
    }
}