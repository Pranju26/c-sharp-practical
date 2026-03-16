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
        XmlSerializer xs = new XmlSerializer(typeof(Employee));

        using (FileStream fs = new FileStream("emp.xml", FileMode.Open))
        {
            Employee e = (Employee)xs.Deserialize(fs);
            Console.WriteLine("Name: " + e.Name);
            Console.WriteLine("Salary: " + e.Salary);
        }
    }
}