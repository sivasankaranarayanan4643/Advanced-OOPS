using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    /// <summary>
    /// Enum class for order status of the instance of <seealso cref="OrderDetails"/>
    /// </summary>
    public enum OrderStatus{Purchased,Cancelled}
    /// <summary>
    /// Class holds the property for order details of the instance of <see cref="OrderDetails"/>
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// static field for auto incrementation of the orderID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        private static int s_orderID=2000;
        /// <summary>
        /// Read only property holds the order ID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string OrderID { get;  }
        /// <summary>
        /// Property holds the user's ID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Property holds the medicine's ID of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// property holds the count of the medicine of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public int MedicineCount { get; set; }
        /// <summary>
        /// Property holds the price of the order of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Property holds the order date of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Property holds the order status of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        /// <summary>
        /// For initializing the value for the property of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="medicineID"></param>
        /// <param name="medicineCount"></param>
        /// <param name="totalPrice"></param>
        /// <param name="orderDate"></param>
        /// <param name="orderStatus"></param>
        public OrderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineID=medicineID;
            OrderDate=orderDate;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;
        }
        /// <summary>
        /// For initializing the value for the property of the instance of <see cref="OrderDetails"/>
        /// </summary>
        /// <param name="order"></param>
        public OrderDetails(string order)
        {
            string[] values=order.Split(',');
            s_orderID=int.Parse(values[0].Remove(0,3));
            OrderID=values[0];
            UserID=values[1];
            MedicineID=values[2];
            OrderDate=DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            MedicineCount=int.Parse(values[3]);
            TotalPrice=double.Parse(values[4]);
            OrderStatus=Enum.Parse<OrderStatus>(values[6]);
        }
    }
}