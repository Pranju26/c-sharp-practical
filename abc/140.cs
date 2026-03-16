using System;

class MyGeneric<T>
{
    private T value;

    public void SetValue(T v) => value = v;
    public T GetValue() => value;
}

class Program
{
    static void Main()
    {
        MyGeneric<int> g1 = new MyGeneric<int>();
        g1.SetValue(100);
        Console.WriteLine(g1.GetValue());

        MyGeneric<string> g2 = new MyGeneric<string>();
        g2.SetValue("Hello World");
        Console.WriteLine(g2.GetValue());
    }
}