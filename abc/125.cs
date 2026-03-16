using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();

        Console.WriteLine("=== LIST<T> DEMONSTRATION ===\n");
        Console.Write("How many names to add? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter name " + (i + 1) + ": ");
            names.Add(Console.ReadLine());
        }

        Console.WriteLine("\n--- Names in List ---");
        names.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("\nAdding ‘NewName’...");
        names.Add("NewName");

        Console.WriteLine("Removing name at index 1...");
        if (names.Count > 1)
            names.RemoveAt(1);

        Console.WriteLine("\n--- Updated List ---");
        names.ForEach(x => Console.WriteLine(x));

        Console.Write("\nEnter name to search: ");
        string s = Console.ReadLine();

        Console.WriteLine(names.Contains(s)
            ? "Name exists in list."
            : "Name not found.");

        Console.WriteLine("\nSorting list...");
        names.Sort();

        Console.WriteLine("\n--- Sorted List ---");
        names.ForEach(x => Console.WriteLine(x));
    }
}