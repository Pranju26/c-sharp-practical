using System;

class BaseClass
{
    public void Show()
    {
        Console.WriteLine("Base Class Show()");
    }
}

class DerivedClass : BaseClass
{
    public new void Show()
    {
        Console.WriteLine("Derived Class Show()");
    }
}

class Program
{
    static void Main()
    {
        BaseClass b = new DerivedClass();
        DerivedClass d = new DerivedClass();

        b.Show(); // Base version
        d.Show(); // Derived version
    }
}