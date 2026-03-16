using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 5, b = 0;
            int c = a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}