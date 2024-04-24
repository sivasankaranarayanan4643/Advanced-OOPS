using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEEDepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }
        

        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("            EEE Department Book     ");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Serial Number: {SerialNumber}\nBook Name: {BookName}\nAuthor Name: {AuthorName}\nPublisher Name: {PublisherName}\nYear: {Year}");
        }
    }
}