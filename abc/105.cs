using System;

class A
{
    public virtual void Show() => Console.WriteLine("Base Class");
}

class B : A
{
    public override void Show() => Console.WriteLine("Derived Class");
}

class Program
{
    static void Main()
    {
        A obj = new B();
        obj.Show();
    }
}