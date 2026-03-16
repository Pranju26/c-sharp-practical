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
        BinaryFormatter bf = new BinaryFormatter();

        using (FileStream fs = new FileStream("person.dat", FileMode.Open))
        {
            Person p = (Person)bf.Deserialize(fs);
            Console.WriteLine("Name: " + p.Name);
            Console.WriteLine("Age: " + p.Age);
        }
    }
}