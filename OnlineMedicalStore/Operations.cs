using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class Operations
    {
        public static CustomList<UserDetails> userList=new CustomList<UserDetails>();
        public static CustomList<MedicineDetails>medicineList=new CustomList<MedicineDetails>();
        public static CustomList<OrderDetails>orderList=new CustomList<OrderDetails>();
        static UserDetails currentLoggedInUser;

        //Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("               Online Medical Store      ");
            Console.WriteLine("----------------------------------------------------");
            string mainMenuExit="no";
            do
            {
                Console.WriteLine("______________Main Menu______________");
                Console.WriteLine("Select an Option\n1. User Registration\n2. User Login\n3. Exit");
                Console.Write("Enter an option: ");
                bool tempMainChoice=int.TryParse(Console.ReadLine(),out int mainChoice);
                while(!tempMainChoice||mainChoice<1|mainChoice>3)
                {
                    Console.Write("Enter a valid option: ");
                    tempMainChoice=int.TryParse(Console.ReadLine(),out  mainChoice);
                }
                switch(mainChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("          User Registration           ");
                        Console.WriteLine("-------------------------------------------");
                        UserRegistration();
                        break;
                    }
                    case 2: 
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              User Login            ");
                        Console.WriteLine("-------------------------------------------");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Application exited successfully");
                        mainMenuExit="yes";
                        break;
                    }
                }
            }while(mainMenuExit=="no");
            
        }//main menu

        //Registration
        public static void UserRegistration()
        {
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your age: ");
            bool tempAge=int.TryParse(Console.ReadLine(),out int age);
            while(!tempAge||age<1)
            {
                Console.Write("Enter a valid age: ");
                tempAge=int.TryParse(Console.ReadLine(),out  age);
            }
            Console.Write("Enter your city: ");
            string city=Console.ReadLine();
            Console.Write("Enter your Phone Number: ");
            string phoneNumber=Console.ReadLine();
            Console.Write("Enter the initial amount to add to your wallet (in rupees): ");
            bool tempBalance=double.TryParse(Console.ReadLine(),out double balance);
            while(!tempBalance||balance<1)
            {
                Console.Write("Enter a valid Amount: ");
                tempBalance=double.TryParse(Console.ReadLine(),out  balance);
            }
            UserDetails user=new UserDetails(name,age,city,phoneNumber,balance);
            userList.Add(user);
            Console.WriteLine($"Registration successful.Your ID is {user.UserID}");
        }//Registration ends

        //Login
        public static void UserLogin()
        {
            Console.Write("Enter your User ID: ");
            string loginID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach (UserDetails user in userList)
            {
                if(user.UserID.Equals(loginID))
                {
                    flag=false;
                    currentLoggedInUser=user;
                    Console.WriteLine("Login successful");
                    Console.WriteLine($"Welcome {user.Name}...");
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid User ID or User ID not found");
            }
        }//Login ends

        //sub menu
        public static void SubMenu()
        {
            string subMenuExit="no";
            do
            {
                Console.WriteLine("______________Sub Menu_____________");
                Console.WriteLine("select an Option\n1. Show Medicine List\n2. Purchase Medicine\n3. Modify Purchase\n4. Cancel Purchase\n5. Show purchase History\n6. Recharge Wallet\n7. Show wallet Balance\n8. Exit");
                bool tempSubChoice=int.TryParse(Console.ReadLine(),out int subChoice);
                while(!tempSubChoice||subChoice<1||subChoice>8)
                {
                    Console.Write("Please enter valid option: ");
                    tempSubChoice=int.TryParse(Console.ReadLine(),out  subChoice);
                }
                switch(subChoice)
                {
                    case 1:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("             Show Medicine List            ");
                        Console.WriteLine("-------------------------------------------");
                        ShowMedicineList();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Purchase Medicine           ");
                        Console.WriteLine("-------------------------------------------");
                        PurchaseMedicine();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Modify Purchase            ");
                        Console.WriteLine("-------------------------------------------");
                        ModifyPurchase();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("                Cancel Purchase           ");
                        Console.WriteLine("-------------------------------------------");
                        CancelPurchase();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("           Show Purchase History            ");
                        Console.WriteLine("-------------------------------------------");
                        ShowPurchaseHistory();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Recharge wallet            ");
                        Console.WriteLine("-------------------------------------------");
                        WalletRecharge();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("             Show Wallet Balance           ");
                        Console.WriteLine("-------------------------------------------");
                        ShowWalletBalance();
                        break;
                    }
                    case 8:
                    {
                        Console.WriteLine("Taking back to Main Menu...");
                        subMenuExit="yes";
                        break;
                    }
                }
            }while(subMenuExit=="no");
        }//submenu ends

        //Show medicine List
        public static void ShowMedicineList()
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"|{"Medicine ID",-10}|{"Medicine Name",-12}|{"Available Count",-10}|{"Price",-5}|{"Date Of Expiry",-13}|");
            Console.WriteLine("----------------------------------------------------------------");
            foreach(MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"|{medicine.MedicineID,-11}|{medicine.MedicineName,-13}|{medicine.AvailableCount,-15}|{medicine.Price,-5}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy"),-14}|");
                Console.WriteLine("----------------------------------------------------------------");
            }
        }//showmedicinelist ends

        public static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.Write("Enter the medicine ID to purchase: ");
            string medicineID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicineID.Equals(medicine.MedicineID))
                {
                    flag=false;
                    Console.Write("Enter the quantity you want to purchase: ");
                    bool tempQuantity=int.TryParse(Console.ReadLine(),out int quantity);
                    while(!tempQuantity||quantity<0)
                    {
                        Console.Write("Enter a valid quantity: ");
                        tempQuantity=int.TryParse(Console.ReadLine(),out quantity);
                    }
                    if(medicine.AvailableCount>=quantity&&medicine.DateOfExpiry>DateTime.Now)
                    {
                        double totalPrice=quantity*medicine.Price;
                        if(currentLoggedInUser.WalletBalance>=totalPrice)
                        {
                            currentLoggedInUser.DeductBalance(totalPrice);
                            medicine.AvailableCount-=quantity;
                            OrderDetails order=new OrderDetails(currentLoggedInUser.UserID,medicine.MedicineID,quantity,totalPrice,DateTime.Now,OrderStatus.Purchased);
                            orderList.Add(order);
                            Console.WriteLine($"Medicine Purchased successfully.Your Order ID is {order.OrderID}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance.Please recharge and make purchase");
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Medicine is not available");
                    }
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid medicine ID or medicine ID not found");
            }
        }//purchaseMedicine ends

        //Modify purchase
        public static void ModifyPurchase()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("|Order ID|User ID|Medicine ID|Medicine Count|Total Price|Order Date|OrderStatus|");
            Console.WriteLine("--------------------------------------------------------------------------------");
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID)&&order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    flag=false;
                    Console.WriteLine($"|{order.OrderID,-8}|{order.UserID,-7}|{order.MedicineID,-11}|{order.MedicineCount,-14}|{order.TotalPrice,-11}|{order.OrderDate.ToString("dd/MM/yyyy"),-10}|{order.OrderStatus,-11}|");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            if(flag)
            {
                Console.WriteLine("No orders found");
            }
            else
            {
                Console.Write("Enter the order ID to modify: ");
                string orderID=Console.ReadLine().ToUpper();
                bool correctID=false;
                foreach(OrderDetails order in orderList)
                {
                    if(orderID.Equals(order.OrderID)&&currentLoggedInUser.UserID.Equals(order.UserID)&&order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        correctID=true;
                        Console.Write("Enter the Modified quantity of the medicine: ");
                        bool tempQuantity=int.TryParse(Console.ReadLine(),out int quantity);
                        while(!tempQuantity||quantity<0)
                        {
                            Console.Write("Enter a valid quantity: ");
                            tempQuantity=int.TryParse(Console.ReadLine(),out quantity);
                        }
                        int pastQuantity=order.MedicineCount;
                        int difference=quantity-pastQuantity;
                        foreach(MedicineDetails medicine in medicineList)
                        {
                            if(order.MedicineID.Equals(medicine.MedicineID))
                            {
                                double totalPrice=difference*medicine.Price;
                                if(medicine.AvailableCount>=difference)
                                {
                                    if(difference>0)
                                    {

                                        if(currentLoggedInUser.WalletBalance>=totalPrice)
                                        {
                                            currentLoggedInUser.DeductBalance(totalPrice);
                                            medicine.AvailableCount-=difference;
                                            order.TotalPrice+=totalPrice;
                                            Console.WriteLine($"The extra cost of {totalPrice} was deducted form your wallet balance");
                                            Console.WriteLine("Order modified successfully");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Modification exited due to insufficient balance.");
                                        }
                                    }
                                    else if(difference<0)
                                    {
                                        medicine.AvailableCount-=difference;
                                        order.TotalPrice+=totalPrice;
                                        currentLoggedInUser.WalletRecharge(Math.Abs(totalPrice));
                                        Console.WriteLine("Order Modified successfully the balance amount has been refunded to your account");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Required quantity not available");
                                }
                                break;
                            }
                        }

                    }
                }
                if(!correctID)
                {
                    Console.WriteLine("Invalid Order ID or Order ID not found");
                }
            }
        }//modify purchase ends


        //Cancelpurchase
        public static void CancelPurchase()
        {
            Console.WriteLine("|Order ID|User ID|Medicine ID|Medicine Count|Total Price|Order Date|OrderStatus|");
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID)&&order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    flag=false;
                    Console.WriteLine($"|{order.OrderID,-10}|{order.UserID,-10}|{order.MedicineID,-10}|{order.MedicineCount,-10}|{order.TotalPrice,-10}|{order.OrderDate.ToString("dd/MM/yyyy"),-10}|{order.OrderStatus}|");
                }
            }
            if(flag)
            {
                Console.WriteLine("No orders found");
            }
            else
            {
                Console.Write("Enter the order ID to cancel: ");
                string orderID=Console.ReadLine().ToUpper();
                bool correctID=false;
                foreach(OrderDetails order in orderList)
                {
                    if(order.OrderID.Equals(orderID)&&currentLoggedInUser.UserID.Equals(order.UserID)&&order.OrderStatus.Equals(OrderStatus.Purchased))
                    {
                        correctID=true;
                        foreach(MedicineDetails medicine in medicineList)
                        {
                            if(medicine.MedicineID.Equals(order.MedicineID))
                            {
                                medicine.AvailableCount+=order.MedicineCount;
                                order.OrderStatus=OrderStatus.Cancelled;
                                currentLoggedInUser.WalletRecharge(order.TotalPrice);
                                Console.WriteLine("Order cancelled successfully");
                                break;
                            }
                        }
                        break;
                    }
                }
                if(!correctID)
                {
                    Console.WriteLine("OrderID invalid or not found");
                }
            }
        }//Cancel purchase ends

        //Show purchase history
        public static void ShowPurchaseHistory()
        {
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("|Order ID|User ID|Medicine ID|Medicine Count|Total Price|Order Date|OrderStatus|");
            Console.WriteLine("--------------------------------------------------------------------------------");
            bool flag=true;
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    flag=false;
                    Console.WriteLine($"|{order.OrderID,-8}|{order.UserID,-7}|{order.MedicineID,-11}|{order.MedicineCount,-14}|{order.TotalPrice,-11}|{order.OrderDate.ToString("dd/MM/yyyy"),-10}|{order.OrderStatus,-11}|");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            if(flag)
            {
                Console.WriteLine("No orders found");
            }
        }//show purchase History ends

        //Recharge wallet
        public static void WalletRecharge()
        {
            Console.Write("Enter the amount to recharge (in rupees): ");
            bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
            while(!tempAmount||amount<1)
            {
                Console.Write("Enter a valid amount");
                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successful. Your current balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//Recharge wallet ends

        //show wallet balance
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your account balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//show wallet balance ends


        //Adding default data
        // public static void AddDefaultData()
        // {
        //     UserDetails user1=new UserDetails("Ravi",33,"Theni","9877774440",400);
        //     UserDetails user2=new UserDetails("Baskaran",33,"Chennai","8847757470",500);
        //     userList.AddRange(new CustomList<UserDetails>{user1,user2});

        //     MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
        //     MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
        //     MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2023,04,30));
        //     MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2024,06,30));
        //     MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));
        //     medicineList.AddRange(new CustomList<MedicineDetails>{medicine1,medicine2,medicine3,medicine4,medicine5});

        //     OrderDetails order1=new OrderDetails(user1.UserID,medicine1.MedicineID,3,15,new DateTime(2022,11,13),OrderStatus.Purchased);
        //     OrderDetails order2=new OrderDetails(user1.UserID,medicine2.MedicineID,2,10,new DateTime(2022,11,13),OrderStatus.Cancelled);
        //     OrderDetails order3=new OrderDetails(user1.UserID,medicine4.MedicineID,2,100,new DateTime(2022,11,13),OrderStatus.Purchased);
        //     OrderDetails order4=new OrderDetails(user2.UserID,medicine3.MedicineID,3,120,new DateTime(2022,11,15),OrderStatus.Cancelled);
        //     OrderDetails order5=new OrderDetails(user2.UserID,medicine5.MedicineID,5,250,new DateTime(2022,11,15),OrderStatus.Purchased);
        //     OrderDetails order6=new OrderDetails(user2.UserID,medicine2.MedicineID,3,15,new DateTime(2022,11,15),OrderStatus.Purchased);
        //     orderList.AddRange(new CustomList<OrderDetails> {order1,order2,order3,order4,order5,order6});
        // }
    }
}