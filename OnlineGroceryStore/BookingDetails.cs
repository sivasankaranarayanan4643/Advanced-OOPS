using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// Enum class holds the booking status
    /// </summary>
    public enum BookingStatus{Default,Initiated,Booked,Cancelled}
    /// <summary>
    /// BookingDetails class holds the property for the Bookings of the instance of <see cref="BookingDetails"/> 
    /// </summary>
    public class BookingDetails
    {
        /// <summary>
        /// BookingDetails class holds the property for the Bookings of the instance of <see cref="BookingDetails"/> 
        /// </summary>
        private static int s_bookingID=3000;
        /// <summary>
        /// Read only property which holds the Booking id of the instance of <see cref="BookingDetails"/>
        /// </summary>
        public string BookingID { get;  }
        /// <summary>
        /// Property holds the Customer ID of the instance <see cref="BookingDetails"/>
        /// </summary>
        public string CustomerID { get; set; } 
        /// <summary>
        /// Property holds the Total price of the instance <see cref="BookingDetails"/>
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property holds the Date of booking of the instance <see cref="BookingDetails"/>
        /// </summary>
        public DateTime DateOfBooking { get; set; }
        /// <summary>
        /// Property holds the Booking status of the instance <see cref="BookingDetails"/>
        /// </summary>
        public BookingStatus BookingStatus { get; set; }
        /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="BookingDetails"/>
        /// </summary>
        public BookingDetails(string customerID,double totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID="BID"+s_bookingID;
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus=bookingStatus;
        }
        /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="BookingDetails"/>
        /// </summary>
        public BookingDetails(string booking)
        {
            string[] values=booking.Split(',');
            s_bookingID=int.Parse(values[0].Remove(0,3));
            BookingID=values[0];
            CustomerID=values[1];
            TotalPrice=double.Parse(values[2]);
            DateOfBooking=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            BookingStatus=Enum.Parse<BookingStatus>(values[4]);
        }

        /// <summary>
        /// Method show Booking details is for showing the booking history to the user of the instance of <see cref="BookingDetails"/>
        /// </summary>
        /// <param name="bookingList"></param>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public static int ShowBookingDetails(CustomList<BookingDetails> bookingList,string customerID)
        {
            int count=0;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"|{"Booking ID",-10}|{"Customer ID",-10}|{"Total Price",-10}|{"Date Of Booking",-15}|{"Booking Status",-10}|");
            Console.WriteLine("-------------------------------------------------------------------");
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingStatus.Equals(BookingStatus.Booked)&&booking.CustomerID.Equals(customerID))
                {
                    count++;
                    Console.WriteLine($"|{booking.BookingID,-10}|{booking.CustomerID,-11}|{booking.TotalPrice,-11}|{booking.DateOfBooking.ToString("dd/MM/yyyy"),-15}|{booking.BookingStatus,-14}|");
                    Console.WriteLine("-------------------------------------------------------------------");
                }          
            }
            return count;
        }

    }
}