using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// Enum class for selecting the gender of the instance of <see cref="PersonalDetails"/>
    /// </summary>
    public enum Gender{Select,Male,Female,Transgender}
    /// <summary>
    /// PersonalDetails class for holding the properties for the user personal information of the instance of <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// property holds the user's name of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// property holds the user's father name of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// property holds the user's gender of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// property holds the user's mobile number of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// property holds the user's DOB of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// property holds the user's MailID of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string MailID { get; set; }
        /// <summary>
        /// For initializing the values for the properties in the class of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">uer's name</param>
        /// <param name="fatherName">user's father naem</param>
        /// <param name="gender">gender of the user</param>
        /// <param name="mobile">mobile number of the user</param>
        /// <param name="dob">DOb of the user</param>
        /// <param name="mailID">MailID of the user</param>
        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
        }
        /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="customer"></param>
        public PersonalDetails(string customer)
        {
            string[] values=customer.Split(',');
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Mobile=values[4];
            DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MailID=values[6];
        }
    }
}