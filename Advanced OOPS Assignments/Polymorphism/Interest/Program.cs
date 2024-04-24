using System;
namespace Interest;
class Program 
{
    public static void Main(string[] args)
    {
        SBI bank1=new SBI();
        ICICI bank2=new ICICI();
        HDFC bank3=new HDFC();
        IDBI bank4=new IDBI();
        Console.WriteLine(bank1.GetInterestInfo(10000));
        Console.WriteLine(bank2.GetInterestInfo(30083));
        Console.WriteLine(bank3.GetInterestInfo(104324));
        Console.WriteLine(bank4.GetInterestInfo(234500));
    }
}