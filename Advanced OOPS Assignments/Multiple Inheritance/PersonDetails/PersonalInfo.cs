using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDetails
{
    public enum Gender{Male,Female}
    public enum MaritalStatus{Married,Single}
    public class PersonalInfo: IShowData
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public MaritalStatus MaritalDetails { get; set; }
        public PersonalInfo(string name,Gender gender,DateTime dob,string phone,MaritalStatus maritalDetails)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone=phone;
            MaritalDetails=maritalDetails;
        }
        public void ShowInfo()
        {
            
            Console.WriteLine($"Name: {Name}\nGender: {Gender}\nDOB: {DOB.ToString("dd/MM/yyyy")}\nPhone: {Phone}\nMarital Details: {MaritalDetails}");
        }

    }
}