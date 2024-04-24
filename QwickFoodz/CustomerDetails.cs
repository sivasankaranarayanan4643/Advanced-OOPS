using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails:PersonalDetails,IBalance
    {
        private static int s_customerID=1000;
        private double _balance=0;
        public string CustomerID { get; }
        public double WalletBalance { get{return _balance;} }

        public CustomerDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location,double balance):base(name,fatherName,gender,mobile,dob,mailID,location)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            _balance=balance;
        }
        public CustomerDetails(string customer):base(customer)
        {
            string[] values=customer.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            _balance=double.Parse(values[8]);
        }

        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }

        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
}