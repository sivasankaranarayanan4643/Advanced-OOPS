using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// User details class for storing user information of an individual of a instance of <see cref="UserDetails"/>
    /// </summary>
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// Static field s_userID used to auto increment the UserID of the instance of <see cref="UserDetails"/>
        /// </summary>
        private static int s_userID=1000;
        /// <summary>
        /// static field _balance used to make the balance not accessible outside the class of the instance of <see cref="UserDetails"/>
        /// </summary>
        private  double _balance=0;
        /// <summary>
        /// Property used to hold User's ID of the instance of <see cref="UserDetails"/>
        /// </summary>
        public string UserID { get;  }

        /// <summary>
        /// Property used to hold Workstation Number of the instance of <see cref="UserDetails"/>
        /// </summary>
        public string WorkStationNumber { get; set; }

        /// <summary>
        /// Property used to hold User's wallet balance of the instance of <see cref="UserDetails"/>
        /// </summary>

        public double WalletBalance { get{return _balance;}  }
        public UserDetails(string name,string fatherName,Gender gender,string mobile,string mailID,string workStationNumber,double balance):base(name,fatherName,gender,mobile,mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            _balance=balance;
        }
        public UserDetails(string user):base(user)
        {
            string[] values=user.Split(',');
            s_userID=int.Parse(values[0].Remove(0,2));
            UserID=values[0];
            WorkStationNumber=values[6];
            _balance=double.Parse(values[7]);
        }
        /// <summary>
        /// wallet recharge for recharging the amount to the private field balance of an instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount to be recharged</param>
        public void WalletRecharge(double amount)
        {
            _balance+=amount;
        } 
         /// <summary>
        /// Deduct amount for deducting the amount from the private field balance of an instance of <see cref="UserDetails"/>
        /// </summary>
        /// <param name="amount">amount to be dedected</param>
        public void DeductAmount(double amount)
        {
            if(_balance>=amount)
            {
                _balance-=amount;
            }
        }
        
    }
}