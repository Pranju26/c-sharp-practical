using System;

class Program
{
    static void Main()
    {
        try
        {
            int x = int.Parse("abc");
        }
        catch
        {
            Console.WriteLine("Error Occurred");
        }
        finally
        {
            Console.WriteLine("Finally Block Executed");
        }
    }
}