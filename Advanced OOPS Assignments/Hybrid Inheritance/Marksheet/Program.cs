using System;
namespace Marksheet;
class Program 
{
    public static void Main(string[] args)
    {
        TheoryExamMarks marks=new TheoryExamMarks("siva","Dharmalingam","6369765310",new DateTime(2001,12,19),Gender.Male,new int[6]{95,96,93,92,93,90},new int[6]{95,96,93,92,93,90},new int[6]{95,96,93,92,93,90},new int[6]{95,96,93,92,93,90});
        StudentMarksheet result=new StudentMarksheet(marks.RegisterNumber,marks.Name,marks.FatherName,marks.Phone,marks.DOB,marks.Gender,marks.Sem1,marks.Sem2,marks.Sem3,marks.Sem4,93,new DateTime(2020,11,15));
        result.CalculateUG();
        result.ShowUGMarksheet();
    }
}