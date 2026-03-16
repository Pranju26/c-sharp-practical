using System;

interface IMessage
{
    void Send();
}

class Email : IMessage
{
    public void Send() => Console.WriteLine("Email Sent");
}

class Notification
{
    private IMessage _msg;
    public Notification(IMessage msg) { _msg = msg; }
    public void Notify() => _msg.Send();
}

class Program
{
    static void Main()
    {
        IMessage email = new Email();
        Notification n = new Notification(email);
        n.Notify();
    }
}