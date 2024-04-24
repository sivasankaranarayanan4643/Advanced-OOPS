using System;
using LibraryManagement;
namespace LibraryMangement;
class Program 
{
    public static void Main(string[] args)
    {
        EEEDepartment book=new EEEDepartment();
        book.SetBookInfo("Siva","C#","Vicky",2018);
        book.DisplayInfo();
        CSEDepartment book1=new CSEDepartment();
        book1.SetBookInfo("sasi","C++","Vasanth",2019);
        book1.DisplayInfo();
    }
}