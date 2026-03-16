using System;

class Car
{
    public string Model;
    public Car(string m) { Model = m; }
    public void Show() => Console.WriteLine("Car Model: " + Model);
}

class Program
{
    static void Main()
    {
        Car c = new Car("BMW");
        c.Show();
    }
}