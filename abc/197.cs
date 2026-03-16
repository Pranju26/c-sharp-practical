using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();

        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");

        list.AddFirst("Start");

        foreach (var item in list)
            Console.WriteLine(item);
    }
}