using System;

interface I1 { void Show1(); }
interface I2 { void Show2(); }

class Demo : I1, I2
{
    public void Show1() => Console.WriteLine("Interface 1");
    public void Show2() => Console.WriteLine("Interface 2");
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show1();
        d.Show2();
    }
}