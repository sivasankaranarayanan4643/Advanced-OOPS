using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDetails
{
    public class EmployeeInfo:FamilyInfo
    {
        private static int s_employeeID=100;
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        public override Update(string name,)
        {
            //showing error as we inherited familyinfo there was a update method already which is sealed so it cannot be override in this class
        }
    }
}