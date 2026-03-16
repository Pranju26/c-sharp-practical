using System;

class Box
{
    public int Length { get; set; }

    public Box(int length)
    {
        Length = length;
    }

    public static Box operator +(Box b1, Box b2)
    {
        return new Box(b1.Length + b2.Length);
    }
}

class Program
{
    static void Main()
    {
        Box b1 = new Box(10);
        Box b2 = new Box(20);

        Box b3 = b1 + b2;

        Console.WriteLine("Combined Length: " + b3.Length);
    }
}