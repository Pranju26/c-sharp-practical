using System;
using System.Reflection;

class Test
{
    public void Show() => Console.WriteLine("Reflection Running...");
}

class Program
{
    static void Main()
    {
        Type t = typeof(Test);
        MethodInfo mi = t.GetMethod("Show");

        object obj = Activator.CreateInstance(t);
        mi.Invoke(obj, null);
    }
}