using System;
namespace StudentDetails;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student1=new StudentInfo("siva","dharmalingam","6369765310","siva@gmail.com",new DateTime(2001,12,19),Gender.Male);
        Console.WriteLine($"------------------------Welcome {student1.Name}--------------------");
        student1.GetStudentInfo();
        student1.ShowInfo();
        HSCDetails hsc=new HSCDetails(student1.RegisterNumber,student1.Standard,student1.Branch,student1.AcademicYear,student1.Name,student1.FatherName,student1.Phone,student1.Mail,student1.DOB,student1.Gender);
        hsc.GetMarks();
        Console.Write("Enter yes to show student's marksheet: ");
        string option=Console.ReadLine();
        hsc.Calculate();
        if(option=="yes")
        {
            hsc.ShowMarksheet();
        }
        StudentInfo student2=new StudentInfo("sasi","dharmalingam","9578782905","sasi@gmail.com",new DateTime(2003,10,24),Gender.Male);
        Console.WriteLine($"------------------------Welcome {student2.Name}--------------------");
        student2.GetStudentInfo();
        student2.ShowInfo();
        HSCDetails hsc1=new HSCDetails(student2.RegisterNumber,student2.Standard,student2.Branch,student2.AcademicYear,student2.Name,student2.FatherName,student2.Phone,student2.Mail,student2.DOB,student2.Gender);
        hsc1.GetMarks();
        Console.Write("Enter yes to show student's marksheet: ");
        string option1=Console.ReadLine();
        hsc1.Calculate();
        if(option1=="yes")
        {
            hsc1.ShowMarksheet();
        }
    }
}