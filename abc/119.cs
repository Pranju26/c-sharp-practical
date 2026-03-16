using System;

class Logger
{
    public void Log(string msg) => Console.WriteLine(msg);
}

class Order
{
    private Logger logger = new Logger();

    public void PlaceOrder()
    {
        logger.Log("Order Placed");
    }
}

class Program
{
    static void Main()
    {
        Order o = new Order();
        o.PlaceOrder();
    }
}