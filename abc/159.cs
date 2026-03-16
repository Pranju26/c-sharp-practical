using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Hello ");
        sb.Append("from ");
        sb.Append("StringBuilder!");

        Console.WriteLine(sb.ToString());
    }
}