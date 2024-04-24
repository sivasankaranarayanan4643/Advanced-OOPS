using System;
using System.Security.Cryptography;
using LibraryManagement;
namespace LibraryMangement;
class Program 
{
    public static void Main(string[] args)
    {
        EEEDepartment book1=new EEEDepartment();
        book1.SetBookInfo("Siva","Embedded system","mugesh",2);
        book1.DisplayInfo();
        CSEDepartment book2=new CSEDepartment();
        book2.SetBookInfo("sasi","C#","siva",4);
        book2.DisplayInfo();

    }
}