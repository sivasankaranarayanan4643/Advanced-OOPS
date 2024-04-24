using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// OrderDetails class holds the property for the Orders of the instance of <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// static field for auto incrementation of the Order id of the instance of <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderID=4000;
        /// <summary>
        /// Read only property which holds the Order id of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; }
        /// <summary>
        /// Property holds the Booking ID of the instance <see cref="OrderDetails"/>
        /// </summary>
        public string BookingID { get; set; }
        /// <summary>
        /// Property holds the Product ID of the instance <see cref="OrderDetails"/>
        /// </summary>
        public string ProductID { get; set; }
        /// <summary>
        /// Property holds the Purchase Count of the instance <see cref="OrderDetails"/>
        /// </summary>
        public int PurchaseCount { get; set; }
        /// <summary>
        /// Property holds the price of order of the instance <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public double PriceOrder { get; set; }
        /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="OrderDetails"/>
        /// </summary>
        public OrderDetails(string bookingID,string productID,int purchaseCount,double priceOrder)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOrder=priceOrder;
        }
        /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="OrderDetails"/>
        /// </summary>
        public OrderDetails(string order)
        {
            string[] values=order.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            BookingID=values[1];
            ProductID=values[2];
            PurchaseCount=int.Parse(values[3]);
            PriceOrder=double.Parse(values[4]);
        }
    }
}