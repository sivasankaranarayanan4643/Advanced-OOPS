using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("QwickFoodz"))
            {
                Console.WriteLine("Creating folder...");
                Directory.CreateDirectory("QwickFoodz");
            }

            if(!File.Exists("QwickFoodz/CustomerDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("QwickFoodz/CustomerDetails.csv").Close();
            }

            if(!File.Exists("QwickFoodz/FoodDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("QwickFoodz/FoodDetails.csv").Close();
            }

            if(!File.Exists("QwickFoodz/ItemDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("QwickFoodz/ItemDetails.csv").Close();
            }

            if(!File.Exists("QwickFoodz/OrderDetails.csv"))
            {
                Console.WriteLine("Creating File...");
                File.Create("QwickFoodz/OrderDetails.csv").Close();
            }
        }


        public static void WriteToCSV()
        {
            string[] customers=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customers[i]=$"{Operations.customerList[i].CustomerID},{Operations.customerList[i].Name},{Operations.customerList[i].FatherName},{Operations.customerList[i].Gender},{Operations.customerList[i].Mobile},{Operations.customerList[i].DOB.ToString("dd/MM/yyyy")},{Operations.customerList[i].MailID},{Operations.customerList[i].Location},{Operations.customerList[i].WalletBalance}";
            }
            File.WriteAllLines("QwickFoodz/CustomerDetails.csv",customers);

            string[] foods=new string[Operations.foodList.Count];

            for(int i=0;i<Operations.foodList.Count;i++)
            {
                foods[i]=$"{Operations.foodList[i].FoodID},{Operations.foodList[i].FoodName},{Operations.foodList[i].PricePerQuantity},{Operations.foodList[i].QuantityAvailable}";
            }
            File.WriteAllLines("QwickFoodz/FoodDetails.csv",foods);

            string[] items=new string[Operations.itemList.Count];
            for(int i=0;i<Operations.itemList.Count;i++)
            {
                items[i]=$"{Operations.itemList[i].ItemID},{Operations.itemList[i].OrderID},{Operations.itemList[i].FoodID},{Operations.itemList[i].PurchaseCount},{Operations.itemList[i].PriceOfOrder}";
            }
            File.WriteAllLines("QwickFoodz/ItemDetails.csv",items);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=$"{Operations.orderList[i].OrderID},{Operations.orderList[i].CustomerID},{Operations.orderList[i].TotalPrice},{Operations.orderList[i].DateOfOrder.ToString("dd/MM/yyyy")},{Operations.orderList[i].OrderStatus}";

            }
            File.WriteAllLines("QwickFoodz/OrderDetails.csv",orders);
        }

        public static void ReadFromCSV()
        {
            string[] customers=File.ReadAllLines("QwickFoodz/CustomerDetails.csv");
            foreach (string customer in customers)
            {
                CustomerDetails customer1=new CustomerDetails(customer);
                Operations.customerList.Add(customer1);
            }
            string[] foods=File.ReadAllLines("QwickFoodz/FoodDetails.csv");
            foreach (string food in foods)
            {
                FoodDetails food1=new FoodDetails(food);
                Operations.foodList.Add(food1);
            }
            string[] items=File.ReadAllLines("QwickFoodz/ItemDetails.csv");
            foreach (string item in items)
            {
                ItemDetails item1=new ItemDetails(item);
                Operations.itemList.Add(item1);
            }
            string[] orders=File.ReadAllLines("QwickFoodz/OrderDetails.csv");
            foreach (string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operations.orderList.Add(order1);
            }
        }
    }
}