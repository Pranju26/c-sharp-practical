using System;

sealed class FinalClass
{
    public void Show() => Console.WriteLine("Sealed Class");
}

class Program
{
    static void Main()
    {
        FinalClass f = new FinalClass();
        f.Show();
    }
}