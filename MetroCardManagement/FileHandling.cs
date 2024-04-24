using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static  class FileHandling
    {
        //creating folder
        public static void Create()
        {
            if(!Directory.Exists("MetroCardManagement"))
            {
                Console.WriteLine("Creating Folder...");
                Directory.CreateDirectory("MetroCardManagement");
            }
            //file for userdetails
            if(!File.Exists("MetroCardManagement/UserDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MetroCardManagement/UserDetails.csv").Close();
            }

            //file for ticket fair details

            if(!File.Exists("MetroCardManagement/TicketFairDetails.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("MetroCardManagement/TicketFairDetails.csv").Close();
            }

            //file for travel details

            if(!File.Exists("MetroCardManagement/TravelDetails.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("MetroCardManagement/TravelDetails.csv").Close();
            }
        }
        
        //writing information to the file
        public static void WriteToCSV()
        {
            //getting userdetails
            string[] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                users[i]=$"{Operations.userList[i].CardNumber},{Operations.userList[i].UserName},{Operations.userList[i].PhoneNumber},{Operations.userList[i].Balance}";
            }
            File.WriteAllLines("MetroCardManagement/UserDetails.csv",users);

            //getting ticket details
            string[] tickets=new string[Operations.ticketList.Count];
            for(int i=0;i<Operations.ticketList.Count;i++)
            {
                tickets[i]=$"{Operations.ticketList[i].TicketID},{Operations.ticketList[i].FromLocation},{Operations.ticketList[i].ToLocation},{Operations.ticketList[i].TicketPrice}";
            }
            File.WriteAllLines("MetroCardManagement/TicketFairDetails.csv",tickets);

            //getting traveldetails
            string[] travels=new string[Operations.travelList.Count];
            for(int  i=0;i<Operations.travelList.Count;i++)
            {
                travels[i]=$"{Operations.travelList[i].TravelID},{Operations.travelList[i].CardNumber},{Operations.travelList[i].FromLocation},{Operations.travelList[i].ToLocation},{Operations.travelList[i].Date.ToString("dd/MM/yyyy")},{Operations.travelList[i].TravelCost}";
            }
            File.WriteAllLines("MetroCardManagement/TravelDetails.csv",travels);
        }

        //getting information from the file
        public static void ReadFromCSV()
        {
            //getting user information
            string[] users=File.ReadAllLines("MetroCardManagement/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operations.userList.Add(user1);
            }

            //getting ticket information
            string[] tickets=File.ReadAllLines("MetroCardManagement/TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                TicketFairDetails ticket1=new TicketFairDetails(ticket);
                Operations.ticketList.Add(ticket1);
            }

            //getting travel information
            string[] travels=File.ReadAllLines("MetroCardManagement/TravelDetails.csv");
            foreach(string travel in travels)
            {
                TravelDetails travel1=new TravelDetails(travel);
                Operations.travelList.Add(travel1);
            }
        }
    }
}