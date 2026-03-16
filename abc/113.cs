using System;

static class Helper
{
    public static void Show() =>
        Console.WriteLine("Static Class Method");
}

class Program
{
    static void Main()
    {
        Helper.Show();
    }
}