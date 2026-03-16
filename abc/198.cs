using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        ConcurrentDictionary<int, string> cd = new ConcurrentDictionary<int, string>();

        Parallel.For(1, 6, i =>
        {
            cd.TryAdd(i, "Value " + i);
        });

        foreach (var item in cd)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}