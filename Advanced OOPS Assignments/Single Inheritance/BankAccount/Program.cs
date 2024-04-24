using System;
namespace BankAccount;
class Program 
{
    public static void Main(string[] args)
    {
        AccountInfo accountHolder1=new AccountInfo("Siva","Dharmalingam","6369765310","siva@gmail.com",new DateTime(2001,12,19),Gender.Male,"Chennai","ABC1002");
        Console.WriteLine($"--------------Welcome {accountHolder1.Name}---------------");
        Console.Write("Enter the initial Deposit amount (in rupees): ");
        accountHolder1.Deposit(double.Parse(Console.ReadLine()));
        accountHolder1.ShowAccountInfo();
        Console.Write("Enter the Amount to withdraw (in rupees): ");
        accountHolder1.Withdraw(double.Parse(Console.ReadLine()));
        accountHolder1.ShowBalance();
        AccountInfo accountHolder2=new AccountInfo("Sasi","Dharmalingam","9578782905","sasi@gmail.com",new DateTime(2003,10,24),Gender.Male,"kodambakkam","ABC1003");
        Console.WriteLine($"--------------Welcome {accountHolder2.Name}---------------");
        Console.Write("Enter the initial Deposit amount (in rupees): ");
        accountHolder2.Deposit(double.Parse(Console.ReadLine()));
        accountHolder2.ShowAccountInfo();
        Console.Write("Enter the Amount to withdraw (in rupees): ");
        accountHolder2.Withdraw(double.Parse(Console.ReadLine()));
        accountHolder2.ShowBalance();
        AccountInfo accountHolder3=new AccountInfo("Vincent","Lord","7639584328","vincent@gmail.com",new DateTime(2000,11,16),Gender.Male,"Nungambakkam","ABC1013");
        Console.WriteLine($"--------------Welcome {accountHolder3.Name}---------------");
        Console.Write("Enter the initial Deposit amount (in rupees): ");
        accountHolder3.Deposit(double.Parse(Console.ReadLine()));
        accountHolder3.ShowAccountInfo();
        Console.Write("Enter the Amount to withdraw (in rupees): ");
        accountHolder3.Withdraw(double.Parse(Console.ReadLine()));
        accountHolder3.ShowBalance();
   

    }
}