using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        Person p = new Person { Name = "Ravi", Age = 30 };

        BinaryFormatter bf = new BinaryFormatter();

        using (FileStream fs = new FileStream("person.dat", FileMode.Create))
        {
            bf.Serialize(fs, p);
        }

        Console.WriteLine("Binary Serialized Successfully!");
    }
}