using System;

class Program
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Action<string> display = msg => Console.WriteLine(msg);
        Predicate<int> isEven = n => n % 2 == 0;

        int result = add(10, 20);
        display("Sum = " + result);

        Console.WriteLine("Is 10 even? " + isEven(10));
    }
}