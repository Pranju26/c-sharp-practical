using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        Console.WriteLine("=== HASHSET DEMO ===\n");

        Console.Write("How many numbers to add? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            if (!set.Add(num))
                Console.WriteLine("Duplicate entry ignored.");
        }

        Console.WriteLine("\n--- HashSet Content ---");
        foreach (int x in set)
            Console.WriteLine(x);

        Console.Write("\nEnter number to check: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine(set.Contains(c)
            ? "Number exists."
            : "Not found.");

        Console.WriteLine("\nRemoving number...");
        if (set.Remove(c))
            Console.WriteLine("Removed successfully.");

        Console.WriteLine("\n--- Updated HashSet ---");
        foreach (int x in set)
            Console.WriteLine(x);
    }
}