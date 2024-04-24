using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// PersonalDetails holds the property for the persons details of the instance of <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Property holds the Name of the person of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Property holds the age of the person of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        /// Property holds the city of the person of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Property holds the phone number of the person of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// For initializing value for the properties of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phoneNumber"></param>
        public PersonalDetails(string name,int age,string city,string phoneNumber)
        {
            Name=name;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
        }

        /// <summary>
        /// For initializing value for the properties of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public PersonalDetails(string user)
        {
            string[]values=user.Split(',');
            Name=values[1];
            Age=int.Parse(values[2]);
            City=values[3];
            PhoneNumber=values[4];
        }
    }
}