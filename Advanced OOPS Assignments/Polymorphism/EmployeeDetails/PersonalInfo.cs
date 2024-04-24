using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public abstract class PersonalInfo
    {
         public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public PersonalInfo(string name,string fatherName,string gender,string mobileNumber)
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
        }
        public abstract void Display();
    }
}