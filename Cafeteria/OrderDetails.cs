using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// DataType OrderStatus used to select a instance of  <see cref="OrderDetails"/> Order status Information 
    /// </summary>
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    /// <summary>
    /// Class OrderDetails used to create instance for Order <see cref="OrderDetails"/> 
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Static field s_orderID used to auto increment the orderID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderID=1000;
        /// <summary>
        /// Property used to hold order's ID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public string OrderID { get; }
        /// <summary>
        /// Property used to hold ordered person User ID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// Property used to hold order place date of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Property used to hold order's TotalPrice of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property used to hold order's status of the instance of <see cref="OrderDetails"/>
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
        public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
        public OrderDetails(string order)
        {
            string[] values=order.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            OrderDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            TotalPrice=double.Parse(values[3]);
            OrderStatus=Enum.Parse<OrderStatus>(values[4]);
        }
    }
}