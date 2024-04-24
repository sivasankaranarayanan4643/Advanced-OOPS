using System;
namespace PersonDetails;
class Program 
{
    public static void Main(string[] args)
    {
        RegisterPerson person=new RegisterPerson("Siva",Gender.Male,new DateTime(2001,12,19),"6369765310",MaritalStatus.Single,new DateTime(2024,01,03),"Dharmalingam","Sankaraganpathi","Chennai",1);
        person.ShowInfo();
        RegisterPerson person1=new RegisterPerson("Sasi",Gender.Male,new DateTime(2003,10,24),"9578782905",MaritalStatus.Single,new DateTime(2024,02,12),"Dharmalingam","Sankaraganpathi","Chennai",1);
        person1.ShowInfo();
    }
}