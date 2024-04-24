using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : RackInfo
    {
        private static int s_bookID=1000;
        public string BookID { get; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,int price):base(departmentName,degree,rackNumber,columnNumber)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("               BookInfo              ");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Book ID: {BookID}\nBook Name: {BookName}\nAuthor Name: {AuthorName}\nDegree :{Degree}\nDepartment Name: {DepartmentName}\nRack Number: {RackNumber}\nColumn Number: {ColumnNumber}\nPrice: {Price}");

        }
    }
}