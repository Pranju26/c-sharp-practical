using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable ht = new Hashtable();

        ht.Add(1, "Apple");
        ht.Add(2, "Banana");
        ht.Add(3, "Orange");

        foreach (DictionaryEntry entry in ht)
            Console.WriteLine(entry.Key + " → " + entry.Value);
    }
}