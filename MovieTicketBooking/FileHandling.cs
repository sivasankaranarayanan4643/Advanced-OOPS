using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("MovieTicketBooking");
            }
            

            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MovieTicketBooking/UserDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MovieTicketBooking/BookingDetails.csv").Close();
            }

            if(!File.Exists("MovieTicketBooking/TheatreDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MovieTicketBooking/TheatreDetails.csv").Close();
            }


            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MovieTicketBooking/MovieDetails.csv").Close();
            }


            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("MovieTicketBooking/ScreeningDetails.csv").Close();
            }
        }

        public static void WriteToCSV()
        {
            string[] users=new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                users[i]=$"{Program.userDetailsList[i].UserID},{Program.userDetailsList[i].WalletBalance},{Program.userDetailsList[i].Name},{Program.userDetailsList[i].Age},{Program.userDetailsList[i].PhoneNumber}";
            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",users);

            string[] bookings=new string[Program.bookingDetailsList.Count];
            for (int i=0; i<Program.bookingDetailsList.Count;i++)
            {
                bookings[i]=$"{Program.bookingDetailsList[i].BookingID},{Program.bookingDetailsList[i].UserID},{Program.bookingDetailsList[i].MovieID},{Program.bookingDetailsList[i].TheatreID},{Program.bookingDetailsList[i].SeatCount},{Program.bookingDetailsList[i].TotalAmount},{Program.bookingDetailsList[i].BookingStatus}";
            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookings);

            string[] movies=new string[Program.movieDetailsList.Count];
            for(int i=0;i<Program.movieDetailsList.Count;i++)
            {
                movies[i]=$"{Program.movieDetailsList[i].MovieID},{Program.movieDetailsList[i].MovieName},{Program.movieDetailsList[i].Language}";
            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movies);

            string[] theatres=new string[Program.theatreDetailsList.Count];
            for(int i=0;i<Program.theatreDetailsList.Count;i++)
            {
                theatres[i]=$"{Program.theatreDetailsList[i].TheatreID},{Program.theatreDetailsList[i].TheatreName},{Program.theatreDetailsList[i].TheatreLocation}";
            }
            File.WriteAllLines("MovieTicketBooking/TheatreDetails.csv",theatres);

            string[] screenings= new string[Program.screeningDetailsList.Count];
            for(int i=0;i<Program.screeningDetailsList.Count;i++)
            {
                screenings[i]=$"{Program.screeningDetailsList[i].MovieID},{Program.screeningDetailsList[i].TheatreID},{Program.screeningDetailsList[i].TicketPrice},{Program.screeningDetailsList[i].NoOfSeats}";
            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screenings);
        }

        public static void ReadFromCSV()
        {
            string[] users=File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            for(int i=users.Length-1;i>=0;i--)
            {
                UserDetails user1=new UserDetails( users[i]);
                Program.userDetailsList.Add(user1);
            }


            string[] bookings=File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            for(int i=bookings.Length-1;i>0;i--)
            {
                BookingDetails booking1=new BookingDetails( bookings[i]);
                Program.bookingDetailsList.Add(booking1);
            }


            string[] movies=File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            for(int i=movies.Length-1;i>=0;i--)
            {
                MovieDetails movie1=new MovieDetails( movies[i]);
                Program.movieDetailsList.Add(movie1);
            }


            string[] theatres=File.ReadAllLines("MovieTicketBooking/TheatreDetails.csv");
            for(int i=theatres.Length-1;i>=0;i--)
            {
                TheatreDetails theatre1=new TheatreDetails( theatres[i]);
                Program.theatreDetailsList.Add(theatre1);
            }


            string[] screenings=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            for(int i=screenings.Length-1;i>=0;i--)
            {
                ScreeningDetails screening1=new ScreeningDetails( screenings[i]);
                Program.screeningDetailsList.Add(screening1);
            }
        }
    }
}