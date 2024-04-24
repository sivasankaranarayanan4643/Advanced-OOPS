using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// Class holds the property for creating user details of the instance of <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails:PersonalDetails,IWallet
    {
        /// <summary>
        /// Static field for auto incrementation of userID of the instance of <see cref="UserDetails"/>
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// Static field for restricting access of the property balance of the instance of <seealso cref="UserDetails"/>
        /// </summary>
        private double _balance=0;
        /// <summary>
        /// Read only property holds user ID of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public string UserID { get; }
        /// <summary>
        /// Read Only property holds user wallet balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <value></value>
        public double WalletBalance { get{return _balance;} }
        /// <summary>
        /// For initializing value for the property of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="balance"></param> 
        public UserDetails(string name,int age,string city,string phoneNumber,double balance):base(name,age,city,phoneNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            _balance=balance;
        }
        /// <summary>
        /// For initializing value for the property of the instance of <see cref="UserDetails"/>
        /// </summary>
        public UserDetails(string user):base(user)
        {
            string[] values=user.Split(',');
            s_userID=int.Parse(values[0].Remove(0,3));
            UserID=values[0];
            _balance=double.Parse(values[5]);
        }
        /// <summary>
        /// method for recharging the amount to the private field balance of the instance of<see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        }
        /// <summary>
        /// method for deducting amount from the private field balance of the instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount"></param>
        public void DeductBalance(double amount)
        {
            _balance-=amount;
        }
    }
}