using System;
namespace OnlineLibrary;
class Program 
{
    public static void Main(string[] args)
    {
        BookInfo book1=new BookInfo("cse","B.E",1,1,"C#","Siva",50);
        BookInfo book2=new BookInfo("eee","B.E",1,2,"HTML","Sasi",100);
        BookInfo book3=new BookInfo("ece","B.E",2,4,"CSS","Vincent",450);
        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();

    }
}