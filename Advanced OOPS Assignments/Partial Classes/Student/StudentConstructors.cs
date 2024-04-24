using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, Gender gender, DateTime dob, string mobile,int physics, int chemistry, int maths)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}