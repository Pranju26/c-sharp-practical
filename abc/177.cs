using System;
using System.Collections;
using System.Collections.Generic;

class MyNumbers : IEnumerable<int>
{
    private int[] nums = { 10, 20, 30, 40 };

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var n in nums)
            yield return n;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

class Program
{
    static void Main()
    {
        MyNumbers m = new MyNumbers();

        foreach (var i in m)
            Console.WriteLine(i);
    }
}