using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    /// <summary>
    /// class file handling is for storing and retrieving application data while closing and opening of instance of<see cref="FileHandling"/>
    /// </summary>
    public class FileHandling
    {
        /// <summary>
        /// Create method for creating files and folders needed for file handling
        /// </summary>
        public static void Create()
        {
            if(!Directory.Exists("Cafeteria"))
            {
                Console.WriteLine("Creating Folder..");
                Directory.CreateDirectory("Cafeteria");
            }
            //file for User details
            if(!File.Exists("Cafeteria/UserDetails.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("Cafeteria/UserDetails.csv").Close();
            }
            //file for CartItems
            if(!File.Exists("Cafeteria/CartItem.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("Cafeteria/CartItem.csv").Close();
            }
            //file for food details
            if(!File.Exists("Cafeteria/FoodDetails.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("Cafeteria/FoodDetails.csv").Close();
            }
            //file for Order details
            if(!File.Exists("Cafeteria/OrderDetails.csv"))
            {
                Console.WriteLine("Creating file...");
                File.Create("Cafeteria/OrderDetails.csv").Close();
            }
            

        }
        /// <summary>
        /// method WriteToCSV for storing the data before that goes in to the garbage
        /// </summary>
        public static void WriteToCSV()
        {
            string[] students=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++ )
            {
                students[i]=$"{Operations.userList[i].UserID},{Operations.userList[i].Name},{Operations.userList[i].FatherName},{Operations.userList[i].Gender},{Operations.userList[i].Mobile},{Operations.userList[i].MailID},{Operations.userList[i].WorkStationNumber},{Operations.userList[i].WalletBalance}";
            }
            File.WriteAllLines("Cafeteria/UserDetails.csv",students);

            string[] cartItems=new string[Operations.cartItemList.Count];
            for(int i=0;i<Operations.cartItemList.Count;i++)
            {
                cartItems[i]=$"{Operations.cartItemList[i].ItemID},{Operations.cartItemList[i].OrderID},{Operations.cartItemList[i].FoodID},{Operations.cartItemList[i].OrderPrice},{Operations.cartItemList[i].OrderQuantity}";
            }
            File.WriteAllLines("Cafeteria/CartItem.csv",cartItems);

            string[] foods=new string[Operations.foodList.Count];
            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foods[i]=$"{Operations.foodList[i].FoodID},{Operations.foodList[i].FoodName},{Operations.foodList[i].FoodPrice},{Operations.foodList[i].FoodQuantity}";
            }
            File.WriteAllLines("Cafeteria/FoodDetails.csv",foods);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=$"{Operations.orderList[i].OrderID},{Operations.orderList[i].UserID},{Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")},{Operations.orderList[i].TotalPrice},{Operations.orderList[i].OrderStatus}";
            }
            File.WriteAllLines("Cafeteria/OrderDetails.csv",orders);
        }
    
        /// <summary>
        /// Method ReadFromCSV for getting the data stored on the files specified
        /// </summary>

        public static void ReadFromCSV()
        {
            string[] users=File.ReadAllLines("Cafeteria/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operations.userList.Add(user1);
            }

            string[] cartItems=File.ReadAllLines("Cafeteria/CartItem.csv");
            foreach(string item in cartItems)
            {
                CartItem item1=new CartItem(item);
                Operations.cartItemList.Add(item1);
            }

            string[] foods=File.ReadAllLines("Cafeteria/FoodDetails.csv");
            foreach(string food in foods)
            {
                FoodDetails food1=new FoodDetails(food);
                Operations.foodList.Add(food1);
            }

            string[] orders=File.ReadAllLines("Cafeteria/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operations.orderList.Add(order1);
            }
        }
    }

}