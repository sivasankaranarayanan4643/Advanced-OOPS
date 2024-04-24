using System;
namespace OnlineGroceryStore;
class Program 
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        Operations.MainMenu();
        FileHandling.WriteToCsv();
    }
}