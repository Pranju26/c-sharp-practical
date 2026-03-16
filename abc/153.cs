using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        using (MemoryStream ms = new MemoryStream())
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello MemoryStream!");
            ms.Write(data, 0, data.Length);

            ms.Position = 0;
            using (StreamReader reader = new StreamReader(ms))
            {
                string result = reader.ReadToEnd();
                Console.WriteLine("Data in MemoryStream: " + result);
            }
        }
    }
}