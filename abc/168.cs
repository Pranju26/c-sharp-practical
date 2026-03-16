using System;

class MyCollection
{
    private int[] arr = new int[5];

    public int this[int index]
    {
        get => arr[index];
        set => arr[index] = value;
    }
}

class Program
{
    static void Main()
    {
        MyCollection c = new MyCollection();

        c[0] = 10;
        c[1] = 20;

        Console.WriteLine("Index 0: " + c[0]);
        Console.WriteLine("Index 1: " + c[1]);
    }
}