using System;
namespace Banking;
class Program 
{
    public static void Main(string[] args)
    {
        SavingsAccount account1=new SavingsAccount("siva",Gender.Male,new DateTime(2001,12,19),"6369765310","abdc2342","328432098832989","jweoi2392","SBI","SBIN00795","Chennai",2000);
        account1.BalanceCheck();
        account1.Deposit(200);
        account1.Withdraw(212);
        account1.BalanceCheck();
        SavingsAccount account2=new SavingsAccount("sasi",Gender.Male,new DateTime(2001,12,19),"6369765310","abdc2342","328432098832989","jweoi2392","SBI","SBIN00795","Chennai",2000);
        account2.BalanceCheck();
        account2.Deposit(200);
        account2.Withdraw(2132);
        account2.BalanceCheck();

    }
}