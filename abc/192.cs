using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("US Format : " + now.ToString(new CultureInfo("en-US")));
        Console.WriteLine("UK Format : " + now.ToString(new CultureInfo("en-GB")));
        Console.WriteLine("India Format : " + now.ToString(new CultureInfo("hi-IN")));
    }
}