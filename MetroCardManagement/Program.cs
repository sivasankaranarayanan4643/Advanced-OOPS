using System;
using MetroCardManagement;
namespace MetroCardMangement;
class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        // Operations.AddDefaultData();
        Operations.MainMenu();
        FileHandling.WriteToCSV();
    }
}