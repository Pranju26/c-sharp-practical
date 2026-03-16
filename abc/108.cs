using System;

interface IAnimal
{
    void Sound();
}

class Dog : IAnimal
{
    public void Sound() => Console.WriteLine("Dog Barks");
}

class Program
{
    static void Main()
    {
        IAnimal a = new Dog();
        a.Sound();
    }
}