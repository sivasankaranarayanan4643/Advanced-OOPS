using System;
using Microsoft.Win32.SafeHandles;
namespace StudentDetails;
class Program 
{
    public static void Main(string[] args)
    {
        
        //creating object for personal info
        PersonalInfo person=new PersonalInfo("siva","Dharmalingam","6369765310","siva@gmail.com",new DateTime(2001,12,19),Gender.Male);
        //creating object for student info
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("            Getting student info             ");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Enter the student's standard: ");
        int standard=int.Parse(Console.ReadLine());
        Console.Write("Enter student department: ");
        string department=Console.ReadLine();
        Console.Write("Enter student's Academic year: ");
        int academicYear=int.Parse(Console.ReadLine());
        StudentInfo student1=new StudentInfo(person.Name,person.FatherName,person.Phone,person.Mail,person.DOB,person.Gender,standard,department,academicYear);
        student1.ShowStudentInfo();
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("            Getting student info             ");
        Console.WriteLine("---------------------------------------------");
        Console.Write("Enter the student's standard: ");
        standard=int.Parse(Console.ReadLine());
        Console.Write("Enter student department: ");
        department=Console.ReadLine();
        Console.Write("Enter student's Academic year: ");
        academicYear=int.Parse(Console.ReadLine());
        StudentInfo student2=new StudentInfo("Govarthana","Karupannan","6382910995","govathana@gmail.com",new DateTime(2001,09,30),Gender.Male,standard,department,academicYear);
        student2.ShowStudentInfo();
    }
}