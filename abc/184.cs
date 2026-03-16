using System;

class Address
{
    public string City { get; set; }
}

class Person
{
    public string Name { get; set; }
    public Address Addr { get; set; }

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public Person DeepCopy()
    {
        return new Person
        {
            Name = this.Name,
            Addr = new Address { City = this.Addr.City }
        };
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person { Name = "Rohan", Addr = new Address { City = "Mumbai" } };

        Person shallow = p1.ShallowCopy();
        Person deep = p1.DeepCopy();

        shallow.Addr.City = "Delhi";
        deep.Addr.City = "Pune";

        Console.WriteLine("Original: " + p1.Addr.City);
        Console.WriteLine("Shallow Copy: " + shallow.Addr.City);
        Console.WriteLine("Deep Copy: " + deep.Addr.City);
    }
}