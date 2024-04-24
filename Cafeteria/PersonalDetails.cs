using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// DataType Gender used to select a instance of  <see cref="PersonalDetails"/> Gender Information 
    /// </summary>
    public enum Gender{Select,Male,Female,Transgender}
    /// <summary>
    /// Class PersonalDetails used to create instance for Person <see cref="PersonalDetails"/> 
    /// </summary>    
    public class PersonalDetails
    {
        /// <summary>
        /// Property used to hold Person's Name of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Property used to hold Person's Father Name of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// Property used to hold Person's gender of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Property used to hold Person's Mobile number of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// Property used to hold Person's mail ID of the instance of <see cref="PersonalDetails"/>
        /// </summary>
        public string MailID { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,string mobile, string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            MailID=mailID;
        }
        public PersonalDetails(string user)
        {
            string[] values=user.Split(',');
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Mobile=values[4];
            MailID=values[5];
        }

    }
}