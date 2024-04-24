using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// Class FoodDetails used to create instance for Food <see cref="FoodDetails"/> 
    /// </summary>
    public class FoodDetails
    {
        /// <summary>
        /// Static field s_foodID used to auto increment the FoodID of the instance of <see cref="FoodDetails"/>
        /// </summary>
        private static int s_foodID=100;
        /// <summary>
        /// Property used to hold food's ID of the instance of <see cref="FoodDetails"/>
        /// </summary>
        public string FoodID { get; }
        /// <summary>
        /// Property used to hold food's Name of the instance of <see cref="FoodDetails"/>
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// Property used to hold food's Price of the instance of <see cref="FoodDetails"/>
        /// </summary>
        public double FoodPrice { get; set; }
        /// <summary>
        /// Property used to hold food's Quantity of the instance of <see cref="FoodDetails"/>
        /// </summary>
        public int FoodQuantity { get; set; }
        public FoodDetails(string foodName,double foodPrice,int foodQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            FoodQuantity=foodQuantity;
        }
        public FoodDetails(string food)
        {
            string[] values=food.Split(',');
            s_foodID=int.Parse(values[0].Remove(0,3));
            FoodID=values[0];
            FoodName=values[1];
            FoodPrice=double.Parse(values[2]);
            FoodQuantity=int.Parse(values[3]);
        }
    }
}