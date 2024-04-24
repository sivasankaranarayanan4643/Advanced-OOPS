using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineMedicalStore"))
            {
                Console.WriteLine("Creating folder...");
                Directory.CreateDirectory("OnlineMedicalStore");
            }

            //creating UserDetails file
            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineMedicalStore/UserDetails.csv").Close();
            }

            //creating MedicineDetails files
            if(!File.Exists("OnlineMedicalStore/MedicineDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineMedicalStore/MedicineDetails.csv").Close();
            }

            //creating order details files
            if(!File.Exists("OnlineMedicalStore/OrderDetails.csv"))
            {
                Console.WriteLine("Creating files....");
                File.Create("OnlineMedicalStore/OrderDetails.csv").Close();
            }

        }

        public static void WriteToCsv()
        {
            string[] users=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            {
                users[i]=$"{Operations.userList[i].UserID},{Operations.userList[i].Name},{Operations.userList[i].Age},{Operations.userList[i].City},{Operations.userList[i].PhoneNumber},{Operations.userList[i].WalletBalance}";
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",users);


            string[] medicines=new string[Operations.medicineList.Count];
            for(int i=0;i<Operations.medicineList.Count;i++)
            {
                medicines[i]=$"{Operations.medicineList[i].MedicineID},{Operations.medicineList[i].MedicineName},{Operations.medicineList[i].AvailableCount},{Operations.medicineList[i].Price},{Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy")}";
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetails.csv",medicines);

            string[] orders=new string[Operations.orderList.Count];
            for(int i=0;i<Operations.orderList.Count;i++)
            {
                orders[i]=$"{Operations.orderList[i].OrderID},{Operations.orderList[i].UserID},{Operations.orderList[i].MedicineID},{Operations.orderList[i].MedicineCount},{Operations.orderList[i].TotalPrice},{Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")},{Operations.orderList[i].OrderStatus}";
            }
            File.WriteAllLines("OnlineMedicalStore/OrderDetails.csv",orders);
        }

        public static void ReadFromCSV()
        {
            string[] users=File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1=new UserDetails(user);
                Operations.userList.Add(user1);
            }

            string[] medicines=File.ReadAllLines("OnlineMedicalStore/MedicineDetails.csv");
            foreach (string medicine in medicines)
            {
                MedicineDetails medicine1=new MedicineDetails(medicine);
                Operations.medicineList.Add(medicine1);
            }

            string[] orders=File.ReadAllLines("OnlineMedicalStore/OrderDetails.csv");
            foreach(string order in orders)
            {
                OrderDetails order1=new OrderDetails(order);
                Operations.orderList.Add(order1);
            }

            
        }

    }
}