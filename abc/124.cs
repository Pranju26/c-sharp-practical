using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        Console.WriteLine("=== ARRAYLIST DEMONSTRATION ===\n");
        Console.Write("How many elements do you want to add? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            string item = Console.ReadLine();
            list.Add(item);
        }

        Console.WriteLine("\n--- Elements in ArrayList ---");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\nAdding a new element: 'NewItem'");
        list.Add("NewItem");

        Console.WriteLine("Removing first element...");
        if (list.Count > 0)
            list.RemoveAt(0);

        Console.WriteLine("\n--- Updated ArrayList ---");
        foreach (var item in list)
            Console.WriteLine(item);

        Console.WriteLine("\nSearching for an element...");
        Console.Write("Enter search term: ");
        string search = Console.ReadLine();

        Console.WriteLine(list.Contains(search)
            ? "Element FOUND!"
            : "Element NOT found.");

        Console.WriteLine("\nProgram Ended.");
    }
}