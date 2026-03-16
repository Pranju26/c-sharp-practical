using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Downloading...");
        string data = await DownloadData();
        Console.WriteLine("Data Received: " + data);
    }

    static async Task<string> DownloadData()
    {
        await Task.Delay(2000);
        return "Sample Server Response";
    }
}