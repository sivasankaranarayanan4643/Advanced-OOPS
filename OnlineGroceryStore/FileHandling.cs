using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class FileHandling
    {
        //creating folder and files
        public static void Create()
        {
            //creating main folder
            if(!Directory.Exists("OnlineGroceryStore"))
            {
                Console.WriteLine("Creating folder...");
                Directory.CreateDirectory("OnlineGroceryStore");
            }

            //creating customerRegistration file
            if(!File.Exists("OnlineGroceryStore/CustomerRegistration.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineGroceryStore/CustomerRegistration.csv").Close();
            }

            //creating productdetails files
            if(!File.Exists("OnlineGroceryStore/ProductDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineGroceryStore/ProductDetails.csv").Close();
            }

            //creating order details files
            if(!File.Exists("OnlineGroceryStore/OrderDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineGroceryStore/OrderDetails.csv").Close();
            }

           //creating booking details files 
            if(!File.Exists("OnlineGroceryStore/BookingDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineGroceryStore/BookingDetails.csv").Close();
            }
        }


        //Write to csv
        public static void WriteToCsv()
        {
            string[] customers=new string[Operations.customerList.Count];
            for(int i=0;i<Operations.customerList.Count;i++)
            {
                customers[i]=$"{Operations.customerList[i].CustomerID},{Operations.customerList[i].Name},{Operations.customerList[i].FatherName},{Operations.customerList[i].Gender},{Operations.customerList[i].Mobile},{Operations.customerList[i].DOB.ToString("dd/MM/yyyy")},{Operations.customerList[i].MailID},{Operations.customerList[i].WalletBalance}";
            }
            File.WriteAllLines("OnlineGroceryStore/CustomerRegistration.csv",customers);


            string[] products=new string[Operations.productList.Count];
            for(int i=0;i<Operations.productList.Count;i++)
            {
                products[i]=$"{Operations.productList[i].ProductID},{Operations.productList[i].ProductName},{Operations.productList[i].QuantityAvailable},{Operations.productList[i].PricePerQuantity}";
            }
            File.WriteAllLines("OnlineGroceryStore/ProductDetails.csv",products);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=$"{Operations.orderList[i].OrderID},{Operations.orderList[i].BookingID},{Operations.orderList[i].ProductID},{Operations.orderList[i].PurchaseCount},{Operations.orderList[i].PriceOrder}";
            }
            File.WriteAllLines("OnlineGroceryStore/OrderDetails.csv",orders);

            string[] bookings=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                bookings[i]=$"{Operations.bookingList[i].BookingID},{Operations.bookingList[i].CustomerID},{Operations.bookingList[i].TotalPrice},{Operations.bookingList[i].DateOfBooking.ToString("dd/MM/yyyy")},{Operations.bookingList[i].BookingStatus}";
            }
            File.WriteAllLines("OnlineGroceryStore/BookingDetails.csv",bookings);
        }

        //read from csv
        public static void ReadFromCSV()
        {
            string[] customers=File.ReadAllLines("OnlineGroceryStore/CustomerRegistration.csv");
            foreach(string customer in customers)
            {
                CustomerRegistration customer1=new CustomerRegistration(customer);
                Operations.customerList.Add(customer1);
            }

            string[] products=File.ReadAllLines("OnlineGroceryStore/ProductDetails.csv");
            foreach (string product in products)
            {
                ProductDetails product1=new ProductDetails(product);
                Operations.productList.Add(product1);
            }

            string[] orders=File.ReadAllLines("OnlineGroceryStore/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operations.orderList.Add(order1);
            }

            string[] bookings=File.ReadAllLines("OnlineGroceryStore/BookingDetails.csv");
            foreach(string booking in bookings)
            {
                BookingDetails booking1=new BookingDetails(booking);
                Operations.bookingList.Add(booking1);
            }
        }
    }
}