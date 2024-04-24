using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// TravelDetails class holding the property for storing travel details of the instance of <see cref="TravelDetails"/>
    /// </summary>
    public class TravelDetails
    {
        /// <summary>
        /// Static field for auto incrementation of the travel id of the instance of <see cref="TravelDetails"/>
        /// </summary>
        private static int s_travelID=2000;
        /// <summary>
        /// Read Only property for holding the travelId of the user of the instanc of <see cref="TravelDetails"/> 
        /// </summary>
        public string TravelID { get;  }
        /// <summary>
        /// Property holds the user card number of the instance of <see cref="TravelDetails"/>
        /// </summary>
        public string CardNumber { get; set; }
        /// <summary>
        /// Property holds the travel starting location of the instance of <see cref="TravelDetails"/>
        /// </summary>
        public string FromLocation { get; set; }
        /// <summary>
        /// Property holds the travel tolocation of the instance of <see cref="TravelDetails"/>
        /// </summary>
        public string ToLocation { get; set; }
        /// <summary>
        /// Property holds the travel date  of the instance of <see cref="TravelDetails"/>
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Property holds the travel cost of the instance of <see cref="TravelDetails"/>
        /// </summary>
        public double TravelCost { get; set; }
        /// <summary>
        /// For initializing the travel details of the instance of <see cref="TravelDetails"/>
        /// </summary>
        /// <param name="cardNumber">cardNumber of the user</param>
        /// <param name="fromLocation">location from the journey starts</param>
        /// <param name="toLocation">location where the journey ends</param>
        /// <param name="date">date of the journey</param>
        /// <param name="travelCost">price of the ticket</param>
        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,double travelCost)
        {
            s_travelID++;
            TravelID="TID"+s_travelID;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }
        /// <summary>
        /// for initializing the properties for the stored data
        /// </summary>
        /// <param name="travel"></param>
        public TravelDetails(string travel)
        {
            string[] values=travel.Split(',');
            s_travelID=int.Parse(values[0].Remove(0,3));
            TravelID=values[0];
            CardNumber=values[1];
            FromLocation=values[2];
            ToLocation=values[3];
            Date=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            TravelCost=double.Parse(values[5]);
        }
    }
}