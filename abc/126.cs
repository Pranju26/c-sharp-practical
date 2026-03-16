using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        Console.WriteLine("=== DICTIONARY DEMO ===\n");
        Console.Write("How many student records? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("\nEnter Roll No: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            students[roll] = name;
        }

        Console.WriteLine("\n--- Student Records ---");
        foreach (var kv in students)
            Console.WriteLine("Roll: " + kv.Key + " | Name: " + kv.Value);

        Console.Write("\nSearch roll no: ");
        int r = int.Parse(Console.ReadLine());

        if (students.ContainsKey(r))
            Console.WriteLine("FOUND: " + students[r]);
        else
            Console.WriteLine("Roll No not found.");

        Console.WriteLine("\nRemoving roll no if exists...");
        if (students.Remove(r))
            Console.WriteLine("Deleted successfully.");

        Console.WriteLine("\nUpdated Dictionary:");
        foreach (var kv in students)
            Console.WriteLine(kv.Key + " : " + kv.Value);
    }
}