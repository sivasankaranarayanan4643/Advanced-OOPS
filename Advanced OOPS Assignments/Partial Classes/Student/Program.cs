using System;
namespace Student;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Siva",Gender.Male,new DateTime(2001,12,19),"6369765310",71,81,81);
        student.Display();
        Console.WriteLine($"your total is {student.CalculateTotal()}");
        Console.WriteLine($"your Percentage is {student.CalculatePercentage()}");
    }
}
