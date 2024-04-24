using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }
        public string Location { get; set; }
        public PersonalDetails(string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            MailID=mailID;
            Location=location;
        }
        public PersonalDetails(string customer)
        {
            string[] values=customer.Split(',');
            Name=values[1];
            FatherName=values[2];
            Gender=Enum.Parse<Gender>(values[3]);
            Mobile=values[4];
            DOB=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MailID=values[6];
            Location=values[7];
        }

    }
}