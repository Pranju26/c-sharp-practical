using System;

abstract class Animal
{
    public abstract void Eat();
}

interface IWalk
{
    void Walk();
}

class Dog : Animal, IWalk
{
    public override void Eat() => Console.WriteLine("Dog Eats");
    public void Walk() => Console.WriteLine("Dog Walks");
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Walk();
    }
}