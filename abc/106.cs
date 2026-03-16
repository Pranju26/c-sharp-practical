using System;

class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing Shape");
}

class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing Circle");
}

class Square : Shape
{
    public override void Draw() => Console.WriteLine("Drawing Square");
}

class Program
{
    static void Main()
    {
        Shape s;
        s = new Circle(); s.Draw();
        s = new Square(); s.Draw();
    }
}