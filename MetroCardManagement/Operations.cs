using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    ///  static class Operations  has the operational methods of the application of the instance of <see cref="Operations"/>
    /// </summary>
    public static class Operations
    {
       
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<TicketFairDetails> ticketList=new CustomList<TicketFairDetails>();
        public static CustomList<TravelDetails> travelList=new CustomList<TravelDetails>();
        static UserDetails currentLoggedInUser;
        

        //MainMenu
        /// <summary>
        /// Main menu method for showing the main menu to the user of the instance of <see cref="Operations"/> 
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                Metro Card MangeMent        ");
            Console.WriteLine("----------------------------------------------------");
            string mainMenuExit="no";
            do
            {
                Console.WriteLine("_____________Main Menu________________");
                Console.WriteLine("Select an Option\n1. New User Registration\n2. Login User\n3. Exit");
                Console.Write("Enter your Option: ");
                bool tempMainChoice=int.TryParse(Console.ReadLine(),out int mainChoice);
                while(!tempMainChoice||mainChoice>3||mainChoice<1)
                {
                    Console.Write("Please select a valid option: ");
                    tempMainChoice=int.TryParse(Console.ReadLine(),out mainChoice);
                }
                switch(mainChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("              User Registration          ");
                        Console.WriteLine("---------------------------------------------");
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("                 Login User          ");
                        Console.WriteLine("---------------------------------------------");
                        LoginUser();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application exited successfully");
                        mainMenuExit="yes";
                        break;
                    }
                }
            }while(mainMenuExit.Equals("no"));
        }//Main menu ends
        
        //UserRegistration
        /// <summary>
        /// User Registration method for getting user information of the instance of <see cref="Operations"/>
        /// </summary>
        public static void UserRegistration()
        {
            Console.Write("Enter your Name: ");
            string userName=Console.ReadLine();
            Console.Write("Enter your Phone number: ");
            string phoneNumber=Console.ReadLine();
            while(phoneNumber[0]<'0'||phoneNumber[0]>'9'){
                Console.Write("Enter a valid phone number: ");
                phoneNumber=Console.ReadLine();
            }
            Console.Write("Enter the initial amount you want to deposit in your wallet(in Rupees): ");
            bool tempBalance=double.TryParse(Console.ReadLine(),out double balance);
            while(!tempBalance||balance<1)
            {
                Console.Write("Enter a valid amount: ");
                tempBalance=double.TryParse(Console.ReadLine(),out  balance);
            }
            UserDetails user=new UserDetails(userName,phoneNumber,balance);
            userList.Add(user);
            Console.WriteLine($"User Registration successful. Your Card Number is {user.CardNumber} ");
        }//user Registration ends

        //Login 
        /// <summary>
        /// Login method makes a gate for the user to view the submenu of the instance of <see cref="Operations"/>
        /// </summary>
        public static void LoginUser()
        {
            Console.Write("Enter your Card Number: ");
            string loginNumber=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(user.CardNumber.Equals(loginNumber))
                {
                    flag=false;
                    Console.WriteLine("Login successful");
                    Console.WriteLine($"Welcome {user.UserName}...");
                    currentLoggedInUser=user;
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid CardNumber or cardNumber not found");
            }
        }//Login ends

        //SubMenu
        /// <summary>
        /// Submenu method shows the option to the logged in user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void SubMenu()
        {
            string subMenuExit="no";
            do
            {
                Console.WriteLine("______________Sub Menu_____________");
                Console.WriteLine("Select an Option\n1. Balance Check\n2. Recharge\n3. View Travel History\n4. Travel\n5. Exit");
                Console.Write("Enter your Option: ");
                bool tempSubChoice=int.TryParse(Console.ReadLine(),out int subChoice);
                while(!tempSubChoice||subChoice<1||subChoice>5)
                {
                    Console.Write("Enter a valid Option: ");
                    tempSubChoice=int.TryParse(Console.ReadLine(),out  subChoice);
                }
                switch(subChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("               Balance Check  ");
                        Console.WriteLine("----------------------------------------------");
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("                  Recharge  ");
                        Console.WriteLine("----------------------------------------------");
                        Recharge();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("               Travel History  ");
                        Console.WriteLine("----------------------------------------------");
                        ViewTravelHistory();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("                  Travel ");
                        Console.WriteLine("----------------------------------------------");
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Taking back to the Main Menu");
                        subMenuExit="yes";
                        break;
                    }
                }
            }while(subMenuExit.Equals("no"));
        }//subMenu ends

        //Balance Check
        /// <summary>
        /// Balance Check method for showing the balance of the logged in user of the instance of<see cref="Operations"/>
        /// </summary>
        public static void BalanceCheck()
        {
            Console.WriteLine($"Your current Balance is Rs.{currentLoggedInUser.Balance}");
        }//Balance check ends

        //Recharge
        /// <summary>
        /// Recharge method for getting amount to be added in the balance and adding them to the balance of the instane of <see cref="Operations"/>
        /// </summary>
        public static void Recharge()
        {
            Console.Write("Enter the amount you want to recharge(in Rupees): ");
            bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
            while(!tempAmount||amount<1)
            {
                Console.Write("Enter a valid amount to recharge: ");
                tempAmount=double.TryParse(Console.ReadLine(),out amount);
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successful. Your current balance is Rs.{currentLoggedInUser.Balance}");
        }//Recharge ends

        //viewTravelHistory
        /// <summary>
        /// ViewTravelHistory method for viewing the past travel history of the logged in user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void ViewTravelHistory()
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine($"|{"Travel ID",-10}|{"Card Number",-10}|{"From Location",-10}|{"ToLocation",-10}|{"Date",-15}|{"TravelCost",-13}|");
            Console.WriteLine("-------------------------------------------------------------------------------");
            bool flag=true;
            foreach(TravelDetails travel in travelList)
            {
                if(travel.CardNumber.Equals(currentLoggedInUser.CardNumber))
                {
                    flag=false;
                    Console.WriteLine($"|{travel.TravelID,-10}|{travel.CardNumber,-11}|{travel.FromLocation,-13}|{travel.ToLocation,-10}|{travel.Date.ToString("dd/MM/yyyy"),-15}|{travel.TravelCost,-13}|");
                    Console.WriteLine("-------------------------------------------------------------------------------");
                }
            }
            if(flag)
            {
                Console.WriteLine("No travel history found");
            }
        }//view travel history ends

        //Travel
        /// <summary>
        /// Travel method for get tickets for the travel of the instance of <see cref="Operations"/>
        /// </summary>
        public static void Travel()
        {
            // 1.	Show the Ticket fair details where the user wishes to travel by getting TicketID.


            TicketFairDetails();
            Console.Write("Enter the ticket ID : ");
            string ticketID=Console.ReadLine().ToUpper();
            bool validID=false;
            foreach(TicketFairDetails ticket in ticketList)
            {
                    // 2.	Check the ticketID is valid. Else show “Invalid user id”.
                if(ticket.TicketID.Equals(ticketID))
                {
                    validID=true;
                    // 3.	IF ticket is valid then, Check the balance from the user object whether it has sufficient balance to travel.
                    if(currentLoggedInUser.Balance>=ticket.TicketPrice)
                    {
                        // 4.	If “Yes” deduct the respective amount from the balance and add the travel details like Card number, From and ToLocation, Travel Date, Travel cost, Travel ID (auto generation) in his travel history.
                        Console.WriteLine($"Ticket Confirmed. Ticket Price Rs.{ticket.TicketPrice} has been deducted from your balance");
                        currentLoggedInUser.DeductBalance(ticket.TicketPrice);
                        TravelDetails travel=new TravelDetails(currentLoggedInUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);
                        travelList.Add(travel);
                    }
                    else
                    {
                        // 5.	If “No” ask him to recharge and go to the “Existing User Service” menu.
                        Console.WriteLine("Insufficient balance. Please Recharge and book ticket");
                    }
                }
            }
            if(!validID)
            {
                Console.WriteLine("Invalid  Ticket ID or ticket ID not found");
            }
        }//travel ends

        //ticket details
        /// <summary>
        /// TicketFairDetails method for getting the ticket fair information of the instance of <see cref="Operations"/>
        /// </summary>
        public static void TicketFairDetails()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"|{"Ticket ID",-10}|{"From Location",-10}|{"To Location",-10}|{"Fair",-5}|");
            Console.WriteLine("--------------------------------------------");
            foreach(TicketFairDetails ticket in ticketList)
            {
                Console.WriteLine($"|{ticket.TicketID,-10}|{ticket.FromLocation,-13}|{ticket.ToLocation,-11}|{ticket.TicketPrice,-5}|");
                Console.WriteLine("--------------------------------------------");

            }
        }
        
        //Adding default data
        // public static void AddDefaultData()
        // {
        //     UserDetails user1=new UserDetails("Ravi","9848812345",1000);
        //     UserDetails user2=new UserDetails("Baskaran","9948854321",1000);
        //     userList.AddRange(new CustomList<UserDetails> {user1,user2});

        //     TicketFairDetails ticket1=new TicketFairDetails("Airport","Egmore",55);
        //     TicketFairDetails ticket2=new TicketFairDetails("Airport","Koyambedu",25);
        //     TicketFairDetails ticket3=new TicketFairDetails("Alandur","Koyambedu",25);
        //     TicketFairDetails ticket4=new TicketFairDetails("Koyambedu","Egmore",32);
        //     TicketFairDetails ticket5=new TicketFairDetails("Vadapalani","Egmore",45);
        //     TicketFairDetails ticket6=new TicketFairDetails("Arumbakkam","Egmore",25);
        //     TicketFairDetails ticket7=new TicketFairDetails("Vadapalani","Koyambedu",25);
        //     TicketFairDetails ticket8=new TicketFairDetails("Arumbakkam","Koyambedu",16);
        //     ticketList.AddRange(new CustomList<TicketFairDetails> {ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});

        //     TravelDetails travel1=new TravelDetails(user1.CardNumber,ticket1.FromLocation,ticket1.ToLocation,new DateTime(2024,10,10),ticket1.TicketPrice);
        //     TravelDetails travel2=new TravelDetails(user1.CardNumber,"Egmore","Koyambedu",new DateTime(2024,10,10),32);
        //     TravelDetails travel3=new TravelDetails(user2.CardNumber,ticket3.FromLocation,ticket3.ToLocation,new DateTime(2024,11,10),ticket3.TicketPrice);
        //     TravelDetails travel4=new TravelDetails(user2.CardNumber,"Egmore","Thirumangalam",new DateTime(2024,11,10),25);
        //     travelList.AddRange(new CustomList<TravelDetails> {travel1,travel2,travel3,travel4});
        // }
    }
}