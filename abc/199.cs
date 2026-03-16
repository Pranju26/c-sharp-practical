using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = "data.bin";

        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            byte[] buffer = Encoding.UTF8.GetBytes("Hello FileStream!");
            fs.Write(buffer, 0, buffer.Length);
        }

        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);

            Console.WriteLine("File Content: " + Encoding.UTF8.GetString(buffer));
        }
    }
}