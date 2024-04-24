using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marksheet
{
    public class TheoryExamMarks:PersonalInfo
    {
        public int[] Sem1 { get; set; }
        public int[] Sem2 { get; set; }
        public int[] Sem3 { get; set; }
        public int[] Sem4 { get; set; }

        public TheoryExamMarks(string name,string fatherName,string phone,DateTime dob,Gender gender,int[] sem1,int[] sem2,int[] sem3,int[] sem4) :base(name,fatherName,phone,dob,gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        public TheoryExamMarks(string registerNumber,string name,string fatherName,string phone,DateTime dob,Gender gender,int[] sem1,int[] sem2,int[] sem3,int[] sem4) :base(registerNumber,name,fatherName,phone,dob,gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
    }
}