using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Machine Name: " + Environment.MachineName);
        Console.WriteLine("OS Version  : " + Environment.OSVersion);
        Console.WriteLine("User Name   : " + Environment.UserName);
        Console.WriteLine("Processors  : " + Environment.ProcessorCount);
        Console.WriteLine("CLR Version : " + Environment.Version);
    }
}