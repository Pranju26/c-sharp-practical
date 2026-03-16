using System;

class Demo
{
    public int a = 10;
    private int b = 20;

    public void Show() => Console.WriteLine("a=" + a + " b=" + b);
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        Console.WriteLine(d.a);
        d.Show();
    }
}