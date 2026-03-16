using System;

abstract class Vehicle
{
    public abstract void Start();
}

class Bike : Vehicle
{
    public override void Start() => Console.WriteLine("Bike Started");
}

class Program
{
    static void Main()
    {
        Vehicle v = new Bike();
        v.Start();
    }
}