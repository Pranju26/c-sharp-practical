using System;
using System.IO;
using System.Xml.Serialization;

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee { Name = "Raj", Salary = 45000 };

        XmlSerializer xs = new XmlSerializer(typeof(Employee));

        using (FileStream fs = new FileStream("emp.xml", FileMode.Create))
        {
            xs.Serialize(fs, e);
        }

        Console.WriteLine("XML Serialized Successfully!");
    }
}