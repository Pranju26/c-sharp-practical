using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();

        Console.WriteLine("=== STACK & QUEUE DEMO ===\n");

        // Stack Input
        Console.Write("How many numbers to push in STACK? ");
        int n1 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n1; i++)
        {
            Console.Write("Enter number: ");
            stack.Push(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\n--- Stack Content (LIFO) ---");
        foreach (var item in stack)
            Console.WriteLine(item);

        Console.WriteLine("\nPopping one item...");
        if (stack.Count > 0)
            Console.WriteLine("Popped: " + stack.Pop());

        // Queue Input
        Console.Write("\nHow many numbers to enqueue in QUEUE? ");
        int n2 = int.Parse(Console.ReadLine());

        for (int i = 0; i < n2; i++)
        {
            Console.Write("Enter number: ");
            queue.Enqueue(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\n--- Queue Content (FIFO) ---");
        foreach (var item in queue)
            Console.WriteLine(item);

        Console.WriteLine("\nDequeuing one item...");
        if (queue.Count > 0)
            Console.WriteLine("Dequeued: " + queue.Dequeue());
    }
}