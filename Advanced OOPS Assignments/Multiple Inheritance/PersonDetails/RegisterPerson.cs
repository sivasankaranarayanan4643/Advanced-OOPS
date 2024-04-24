using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public class RegisterPerson:PersonalInfo,IFamilyInfo,IShowData
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber { get; }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int NoOfSiblings { get; set; }
        public RegisterPerson(string name,Gender gender,DateTime dob,string phone,MaritalStatus maritalDetails,DateTime dateOfRegistration,string fatherName,string motherName,string houseAddress,int noOfSiblings):base(name,gender,dob,phone,maritalDetails)
        {
            s_registerNumber++;
            RegisterNumber="PID"+s_registerNumber;
            DateOfRegistration=dateOfRegistration;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            NoOfSiblings=noOfSiblings;
        }
        public new void  ShowInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("           Register Person Info");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Register Number: {RegisterNumber}\nRegister Date:{DateOfRegistration.ToString("dd/MM/yyyy")}");
            base.ShowInfo();
            Console.WriteLine($"Father Name: {FatherName}\nMother Name:{MotherName}\nHouse Address: {HouseAddress}\nNo. Of Siblings: {NoOfSiblings}");
        }
    }
}