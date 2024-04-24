using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// TicketFairDetails class holds the property for the ticket details of the instance of <see cref="TicketFairDetails"/> 
    /// </summary>
    public class TicketFairDetails
    {
        /// <summary>
        /// static field for auto increment the ticket ID of the instance of <see cref="TicketFairDetails"/>
        /// </summary>
        private static int s_ticketID=3000;
        /// <summary>
        /// Read only property which holds the ticket ID of the instance of <see cref="TicketFairDetails"/> 
        /// </summary>
        public string TicketID { get;  }
        /// <summary>
        /// Property holds the fromlocation of the train of the instance of <see cref="TicketFairDetails"/>
        /// </summary>
        public string FromLocation { get; set; }
        /// <summary>
        /// Property holds the  tolocation of the train of the instance of <see cref="TicketFairDetails"/>
        /// </summary>
        public string ToLocation { get; set; }
        /// <summary>
        /// Property holds the ticket price of the train of the instance of <see cref="TicketFairDetails"/>
        /// </summary>
        public double TicketPrice { get; set; }
        /// <summary>
        /// for initializing the ticketdetails of the instance of <see cref="TicketFairDetails"/>
        /// </summary>
        /// <param name="fromLocation">location from the journey starts</param>
        /// <param name="toLocation">location to the journey ends</param>
        /// <param name="ticketPrice">price of the ticket</param>
        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;
        }
        /// <summary>
        /// for intializing the ticketdetails of the stored data
        /// </summary>
        /// <param name="ticket"></param>
        public TicketFairDetails(string ticket)
        {
            string[] values=ticket.Split(',');
            s_ticketID=int.Parse(values[0].Remove(0,2));
            TicketID=values[0];
            FromLocation=values[1];
            ToLocation=values[2];
            TicketPrice=double.Parse(values[3]);
        }
    }
}