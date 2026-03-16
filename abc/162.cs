using System;
using System.Text;

class Program
{
    static void Main()
    {
        string normal = "";
        var sb = new StringBuilder();

        // String
        for (int i = 0; i < 5000; i++)
            normal += "A";

        // StringBuilder
        for (int i = 0; i < 5000; i++)
            sb.Append("A");

        Console.WriteLine("String Length     : " + normal.Length);
        Console.WriteLine("StringBuilder Len : " + sb.Length);
    }
}