using System;

[AttributeUsage(AttributeTargets.Class)]
class InfoAttribute : Attribute
{
    public string Message { get; }

    public InfoAttribute(string msg) => Message = msg;
}

[Info("This is a sample class")]
class MyClass { }

class Program
{
    static void Main()
    {
        Type t = typeof(MyClass);
        var attr = (InfoAttribute)Attribute.GetCustomAttribute(t, typeof(InfoAttribute));

        Console.WriteLine("Attribute Message: " + attr.Message);
    }
}