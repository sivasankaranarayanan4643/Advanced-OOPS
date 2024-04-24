using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking
{
    public class SavingsAccount:IDInfo,ICalculate,IBankInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber { get;  }
        public string AccountType { get; set; }
        public double Balance { get;set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public SavingsAccount(string name,Gender gender,DateTime dob,string phone,string voterID,string aadharID,string panNumber,string bankName,string ifsc,string branch,double balance):base(name,gender,dob,phone,voterID,aadharID,panNumber)
        {
            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            AccountType="Savings";
            BankName=bankName;
            IFSC=ifsc;
            Branch=branch;
            Balance=balance;
        }
        public void Deposit(double amount)
        {
            Balance+=amount;
        }
        public void Withdraw(double amount)
        {
            if(Balance>=amount)
            {
                Balance-=amount;
            }
            else{
                Console.WriteLine("Insufficient balance");
            }
        }
        public void BalanceCheck()
        {
            Console.WriteLine($"Your Current Balance is Rs.{Balance}");
        }
    }
}