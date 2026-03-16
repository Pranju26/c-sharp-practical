using System;
using System.Collections.Generic;

class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int CompareTo(Product other)
    {
        return Price.CompareTo(other.Price);
    }
}

class Program
{
    static void Main()
    {
        List<Product> p = new List<Product>()
        {
            new Product { Name = "Laptop", Price = 55000 },
            new Product { Name = "Mouse", Price = 600 },
            new Product { Name = "Keyboard", Price = 1200 }
        };

        p.Sort();

        foreach (var item in p)
            Console.WriteLine(item.Name + " - " + item.Price);
    }
}