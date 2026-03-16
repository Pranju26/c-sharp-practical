using System;

class A
{
    public virtual void Display() => Console.WriteLine("A Display");
}

class B : A
{
    public override void Display() => Console.WriteLine("B Display");
}

class Program
{
    static void Main()
    {
        A obj = new B();
        obj.Display();
    }
}