using System;

class Program
{
    delegate void MyDelegate(string msg);

    static void Main()
    {
        MyDelegate del = delegate (string msg)
        {
            Console.WriteLine("Anonymous Method says: " + msg);
        };

        del("Hello!");
    }
}