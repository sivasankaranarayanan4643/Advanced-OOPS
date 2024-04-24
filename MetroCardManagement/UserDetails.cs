using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// UserDetails class for storing the registered user details which inherits personal details and IBalance classes of the instanc eof <see cref="UserDetails"/> 
    /// </summary>
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// static value for auto incrementation of CardNumber of the instance of <see cref="UserDetails"/>
        /// </summary>
        private static int s_cardNumber=1000;
        /// <summary>
        /// static value for restrict the accessiblity of the wallet balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        private double _balance=0;
        /// <summary>
        /// Read only property which holds the Cardnumber of the user of the instance of <see cref="UserDetails"/>
        /// </summary>
        public string CardNumber { get;  }
        /// <summary>
        /// read only property which holds the users account balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public double Balance { get{return _balance;} }
        /// <summary>
        /// For initializing data for the new user of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="userName">name of the user</param>
        /// <param name="phoneNumber">phone number of the user</param>
        /// <param name="balance">balance of the user</param>
        /// <returns></returns>
        public UserDetails(string userName,string phoneNumber,double balance):base(userName,phoneNumber)
        {
            s_cardNumber++;
            CardNumber="CMR"+s_cardNumber;
            _balance=balance;
        }
        /// <summary>
        /// For initializing property for the stored data
        /// </summary>
        /// <param name="user"></param>
        public UserDetails(string user):base(user)
        {
            string[]values=user.Split(',');
            s_cardNumber=int.Parse(values[0].Remove(0,3));
            CardNumber=values[0];
            _balance=double.Parse(values[3]);
        }
        /// <summary>
        /// Method wallet recharge for adding amount to the private field balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount to be recharged</param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        /// <summary>
        /// Method Deduct Amount for deducting the amount from the private field balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount to be deducted </param>
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }

    }
}