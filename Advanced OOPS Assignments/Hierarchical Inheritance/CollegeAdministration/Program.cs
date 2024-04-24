using System;
namespace CollegeAdministration;
class Program 
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Siva","dharmalingam",new DateTime(2001,12,19),"6369765310",Gender.Male,"siva@gmail.com","B.E","CSE",8);
        student.ShowDetails();
        Teacher teacher=new Teacher("Teacher","Father",new DateTime(1990,12,22),"9787675747",Gender.Male,"teacher@gmail.com","CSE","C#","M.E",5,new DateTime(2018,11,23));
        teacher.ShowDetails();
        PrincipalInfo principal=new PrincipalInfo("Principal","Father",new DateTime(1990,12,22),"6757473727",Gender.Male,"principal@gmail.com","M.E,Ph.d",5,new DateTime(2018,11,23));
        principal.ShowDetails();
    }
}