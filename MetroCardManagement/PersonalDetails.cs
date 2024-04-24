using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// PersonalDetails class for storing the personal information of the user inherited of the instance of <see cref="PersonalDetails"/> 
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Property hold the person's name of the instance of <see cref="PersonalDetails"/> 
        /// </summary>
        public string UserName { get; set; }
         /// <summary>
        /// Property hold the person's Phone number of the instance of <see cref="PersonalDetails"/> 
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// For initializing property for new user
        /// </summary>
        /// <param name="userName">name of the user</param>
        /// <param name="phoneNumber">phone number of the user</param>
        public PersonalDetails(string userName,string phoneNumber)
        {
            UserName=userName;
            PhoneNumber=phoneNumber;
        }
        /// <summary>
        /// for initializing property for the stored data
        /// </summary>
        /// <param name="user"></param>
        public PersonalDetails(string user)
        {
            string[]values=user.Split(',');
            UserName=values[1];
            PhoneNumber=values[2];
        }
    }
}