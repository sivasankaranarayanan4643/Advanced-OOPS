using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDetails
{
    public class FamilyInfo:PersonalInfo
    {
        public string MotherName { get; set; }
        public int NoOfSiblings { get; set; }
        public string NativePlace { get; set; }
        public sealed override void Update(string name, string fatherName, string mobile, string mail, string gender)
        {
            base.Update(name, fatherName, mobile, mail, gender);
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}\nFather Name:{FatherName}\nMother Name: {MotherName}\nNo Of Siblings: {NoOfSiblings}\nNative Place:  {NativePlace}\nMobile: {Mobile}\nGender: {Gender}");
        }
    }
}