using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marksheet
{
    public enum Gender {Male,Female}
    public class PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get;  }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name, string fatherName,string phone,DateTime dob, Gender gender)
        {
            s_registerNumber++;
            RegisterNumber="SID"+s_registerNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }
        public PersonalInfo(string registerNumber,string name, string fatherName,string phone,DateTime dob, Gender gender)
        {
            
            RegisterNumber=registerNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            Gender=gender;
        }
    }
}