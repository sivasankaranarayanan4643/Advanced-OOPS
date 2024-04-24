using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// Customer registration class holds the property of user's account information of the instance of <see cref="CustomerRegistration"/>
    /// </summary>
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        /// <summary>
        /// static field for the auto incrementation of the customer ID
        /// </summary>
        private static int s_customerID=1000;
        /// <summary>
        /// private field for restrict the access from the user to directly change balance of the instance of <see cref="CustomerRegistration"/>
        /// </summary>
        private double _balance=0;
        /// <summary>
        /// Read only property which holds the customer ID of the instance of <see cref="CustomerRegistration"/>
        /// </summary>
        /// <value></value>
        public string CustomerID { get;  }
        /// <summary>
        /// Read Only property which holds the customers balance of the instance of <see cref="CustomerRegistration"/>
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} }

         /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="customer"></param>
        public CustomerRegistration(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,double balance):base(name,fatherName,gender,mobile,dob,mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            _balance=balance;
        }
         /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="customer"></param>
        public CustomerRegistration(string customer):base(customer)
        {
            string[] values=customer.Split(',');
            s_customerID=int.Parse(values[0].Remove(0,3));
            CustomerID=values[0];
            _balance=double.Parse(values[7]);
        }

        /// <summary>
        /// WalletRecharge method for adding amount to the customer balance
        /// </summary>
        /// <param name="amount">amount to be added</param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }

        /// <summary>
        /// Deduct amount method for deducting amount from the user
        /// </summary>
        /// <param name="amount">amount to be deducted</param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void DeductAmount(double amount)
        {
            _balance-=amount;
        }
    }
}