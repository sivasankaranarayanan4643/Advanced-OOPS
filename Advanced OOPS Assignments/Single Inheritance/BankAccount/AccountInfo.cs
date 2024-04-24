using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        private static int s_accountNumber=1000;
        private double _balance=0;
        public string AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public double Balance { get{return _balance;}  }

        public AccountInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender, string branchName,string ifscCode):base(name,fatherName,phone,mail,dob,gender)
        {
            s_accountNumber++;
            AccountNumber="AID"+s_accountNumber;
            BranchName=branchName;
            IFSCCode=ifscCode;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                Account Info                  ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Name: {Name}\nAccount Number: {AccountNumber}\nBranch Name: {BranchName}\nIFSC Code: {IFSCCode}\nFather Name: {FatherName}\nPhone: {Phone}\nMail: {Mail}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nGender: {Gender}\nBalance: {Balance}");
        }
        public void Deposit(double amount)
        {
            _balance+=amount;
            Console.WriteLine("Amount deposited successfully");
        }

        public void Withdraw(double amount)
        {
            if(Balance>amount)
            {
                _balance-=amount;
                Console.WriteLine("Withdraw successful");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Your current Balance is Rs.{Balance}");
        }
    }
}