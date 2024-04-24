using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistration
{
    public sealed class EmployeeInfo:
    {
        private static int s_userID=100;
        public string UserID { get; }
        public string Password { get; set; }
        //without inheriting the personal info class cannot access the properties of that class directly
          public void UpdateInfo(string name,string fatherName,string phone,string mail,string gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;

        }
    }
}