using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (MemoryStream ms = new MemoryStream())
        {
            string text = "Hello MemoryStream!";
            byte[] buffer = Encoding.UTF8.GetBytes(text);

            ms.Write(buffer, 0, buffer.Length);

            ms.Position = 0;

            StreamReader sr = new StreamReader(ms);
            Console.WriteLine("Data: " + sr.ReadToEnd());
        }
    }
}