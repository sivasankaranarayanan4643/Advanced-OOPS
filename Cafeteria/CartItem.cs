using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// Class CartItem used to create instance for items in the cart <see cref="CartItem"/> 
    /// </summary>
    public class CartItem
    {
        /// <summary>
        /// Static field s_itemID used to auto increment the ItemID of the instance of <see cref="CartItem"/>
        /// </summary>
        private static int s_itemID=100;
        /// <summary>
        /// Property used to hold item's ID of the instance of <see cref="CartItem"/>
        /// </summary>
        public string ItemID { get;}
        /// <summary>
        /// Property used to hold item's OrderID of the instance of <see cref="CartItem"/>
        /// </summary>
        public String OrderID { get; set; }
        /// <summary>
        /// Property used to hold item's FoodID of the instance of <see cref="CartItem"/>
        /// </summary>
        public string FoodID { get; set; }
        /// <summary>
        /// Property used to hold item's Order price of the instance of <see cref="CartItem"/>
        /// </summary>
        public double OrderPrice { get; set; }
        /// <summary>
        /// Property used to hold item's Order quantity of the instance of <see cref="CartItem"/>
        /// </summary>
        public int OrderQuantity { get; set; }
        public CartItem(string orderID,string foodID,double orderPrice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
        public CartItem(string cartItem)
        {
            string[]values=cartItem.Split(',');
            s_itemID=int.Parse(values[0].Remove(0,4));
            ItemID=values[0];
            OrderID=values[1];
            FoodID=values[2];
            OrderPrice=double.Parse(values[3]);
            OrderQuantity=int.Parse(values[4]);
        }
    }
}