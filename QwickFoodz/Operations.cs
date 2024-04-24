using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operations
    {
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<ItemDetails> itemList = new CustomList<ItemDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        static CustomerDetails currentLoggedInUser;

        //MainMenu
        public static void MainaMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("            Qwick Foodz");
            Console.WriteLine("----------------------------------------");
            string mainMenuExit = "no";
            do
            {
                Console.WriteLine("______________Main Menu_______________");
                Console.WriteLine("Select an Option\n1. Customer Registration\n2. Customer Login\n3. Exit");
                Console.Write("Enter the Option: ");
                bool tempMainChoice=int.TryParse(Console.ReadLine(),out int mainChoice);
                while(!tempMainChoice||mainChoice<1||mainChoice>3)
                {
                    Console.Write("Plese enter a valid Option: ");
                    tempMainChoice=int.TryParse(Console.ReadLine(),out  mainChoice);
                }
                switch (mainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("          Customer Registration");
                            Console.WriteLine("----------------------------------------");
                            CustomerRegistration();
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("            Customer Login");
                            Console.WriteLine("----------------------------------------");
                            CustomerLogin();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("Application exited successfully");
                            mainMenuExit = "yes";
                            break;
                        }
                }
            } while (mainMenuExit.Equals("no"));
        }//main menu ends

        //Customer Registration
        public static void CustomerRegistration()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender(Male/Female/Transgender): ");
            bool tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out Gender gender);
            while(!tempGender)
            {
                Console.Write("Enter Valid Gender: ");
                tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out  gender);
            }
            Console.Write("Enter your mobile Number: ");
            string mobile = Console.ReadLine();
            Console.Write("Enter your DOB as specified(dd/MM/yyyy): ");
            bool tempDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime dob);
            while(!tempDOB)
            {
                Console.Write("Please enter the DOB as specified(dd/MM/yyyy): ");
                tempDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out  dob);
            }
            Console.Write("Enter your mailID: ");
            string mailID = Console.ReadLine();
            Console.Write("Enter your Location: ");
            string location = Console.ReadLine();
            Console.Write("Enter the initial amount you want to add in your wallet: ");
            bool tempBalance=double.TryParse(Console.ReadLine(),out double balance);
            while(!tempBalance||balance<1)
            {
                Console.Write("Enter a valid amount: ");
                tempBalance=double.TryParse(Console.ReadLine(),out  balance);
            }
            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID, location, balance);
            customerList.Add(customer);
            Console.WriteLine($"Customer Registration successful Your Customer ID: {customer.CustomerID}");
        }//customer registration ends

        public static void CustomerLogin()
        {
            Console.Write("Enter the Customer ID: ");
            string loginID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (customer.CustomerID.Equals(loginID))
                {
                    flag = false;
                    currentLoggedInUser = customer;
                    Console.WriteLine("Login Successful");
                    Console.WriteLine($"Welcome {customer.Name}");
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid customer ID or customer id not found");
            }
        }//Customer Login ends

        //subMenu
        public static void SubMenu()
        {
            string subMenuExit = "no";
            do
            {
                Console.WriteLine("______________Main Menu_______________");
                Console.WriteLine("Select an Option\n1. Show Profile\n2. Order Food\n3. Cancel Order\n4. Modify Order\n5. Order History\n6. Recharge Wallet\n7. Show Wallet Balance\n8. Exit");
                Console.Write("Enter the Option: ");
                bool tempSubChoice=int.TryParse(Console.ReadLine(),out int subChoice);
                while(!tempSubChoice||subChoice<1||subChoice>8)
                {
                    Console.Write("Enter a valid option: ");
                    tempSubChoice=int.TryParse(Console.ReadLine(),out  subChoice);
                }
                switch (subChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("          Show Profile");
                            Console.WriteLine("----------------------------------------");
                            ShowProfile();
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("            Order Food");
                            Console.WriteLine("----------------------------------------");
                            OrderFood();
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("            Cancel Order");
                            Console.WriteLine("----------------------------------------");
                            CancelOrder();
                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("            Modify Order");
                            Console.WriteLine("----------------------------------------");
                            ModifyOrder();
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("             Order History");
                            Console.WriteLine("----------------------------------------");
                            OrderHistory();
                            break;

                        }
                    case 6:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("             Recharge Wallet");
                            Console.WriteLine("----------------------------------------");
                            RechargeWallet();
                            break;

                        }
                    case 7:
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("          Show Wallet Balance");
                            Console.WriteLine("----------------------------------------");
                            ShowWalletBalance();
                            break;

                        }
                    case 8:
                        {
                            Console.WriteLine("Taking back to the main menu");
                            subMenuExit = "yes";
                            break;
                        }
                }
            } while (subMenuExit.Equals("no"));
        }//sub menu ends

        //show profile
        public static void ShowProfile()
        {
            Console.WriteLine($"Name: {currentLoggedInUser.Name}\nFather Name: {currentLoggedInUser.FatherName}\nGender: {currentLoggedInUser.Gender}\nMobile: {currentLoggedInUser.Mobile}\nDOB: {currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}\nLocation: {currentLoggedInUser.Location}");
        }//show profile ends


        //Order food
        public static void OrderFood()
        {
            OrderDetails order = new OrderDetails(currentLoggedInUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
            CustomList<ItemDetails> tempItemList = new CustomList<ItemDetails>();
            string continuePurchase = "yes";
            do
            {
                ShowFoodDetails();
                Console.Write("Enter the food ID you want to purchase: ");
                string foodID = Console.ReadLine().ToUpper();
                bool flag = true;
                foreach (FoodDetails food in foodList)
                {
                    if (foodID.Equals(food.FoodID))
                    {
                        flag = false;
                        Console.Write("Enter the quantity you want to purchase: ");
                        bool tempQuantity=int.TryParse(Console.ReadLine(),out int quantity);
                        while(!tempQuantity||quantity<0)
                        {
                            Console.Write("Enter a valid Quantity: ");
                            tempQuantity=int.TryParse(Console.ReadLine(),out  quantity);
                        }
                        if (food.QuantityAvailable >= quantity)
                        {
                            double totalPrice = quantity * food.PricePerQuantity;
                            ItemDetails item = new ItemDetails(order.OrderID, food.FoodID, quantity, totalPrice);
                            food.QuantityAvailable -= quantity;
                            tempItemList.Add(item);
                            Console.Write("Enter yes if you want add another food: ");
                            continuePurchase = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("Required quantity not available");
                            Console.Write("Enter yes if you want add another food: ");
                            continuePurchase = Console.ReadLine().ToLower();
                        }
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid food Id or food Id not found");
                    Console.Write("Enter yes if you want add another food: ");
                    continuePurchase = Console.ReadLine().ToLower();
                }
            } while (continuePurchase.Equals("yes"));
            if (tempItemList.Count > 0)
            {
                Console.Write("Enter yes if you want to confirm the order: ");
                string confirmOrder = Console.ReadLine();
                bool ordered = false;
                double price = CalculateTotalPrice(tempItemList);
                if (confirmOrder.Equals("yes"))
                {
                    price = CalculateTotalPrice(tempItemList);
                    if (currentLoggedInUser.WalletBalance >= price)
                    {
                        ordered = true;
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                        Console.Write("Enter yes if you wish to recharge and continue: ");
                        string isRecharge = Console.ReadLine().ToLower();
                        if (isRecharge.Equals("yes"))
                        {
                            Console.Write("Enter the amount to recharge: ");
                            bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
                            while(!tempAmount||amount<1)
                            {
                                Console.Write("Please enter a valid amount: ");
                                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                            }
                            currentLoggedInUser.WalletRecharge(amount);
                            while (currentLoggedInUser.WalletBalance < price)
                            {
                                Console.Write("Insufficient balance.Enter the amount to recharge");
                                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                                while(!tempAmount||amount<1)
                                {
                                    Console.Write("Please enter a valid amount: ");
                                    tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                                }
                                currentLoggedInUser.WalletRecharge(amount);
                            }
                            ordered = true;
                        }
                        else
                        {
                            ReturnFood(tempItemList);
                            Console.WriteLine("Purchase cancelled due to insufficient balance");
                        }
                    }
                    if (ordered)
                    {
                        currentLoggedInUser.DeductBalance(price);
                        order.TotalPrice = price;
                        order.OrderStatus = OrderStatus.Ordered;
                        orderList.Add(order);
                        Console.WriteLine($"purchase successful your OrderID is {order.OrderID}");
                    }
                }
                else
                {
                    ReturnFood(tempItemList);
                    Console.WriteLine("Exiting to service menu...");
                }
            }
            else
            {
                Console.WriteLine("Exiting to service menu...");
            }
        }//order food ends

        //Cancel Order
        public static void CancelOrder()
        {
            CustomList<ItemDetails> tempItemList = new CustomList<ItemDetails>();
            // a.	Show the list of orders placed by current logged in user whose status is “Ordered”.
            int count = OrderedFoods();
            // b.	Ask the user to pick an order to be cancelled by OrderID.
            if (count > 0)
            {
                Console.Write("Enter the order ID of the order to be cancelled: ");
                string orderID = Console.ReadLine().ToUpper();
                bool flag = true;
                // c.	If OrderID is present, then change the order status to “Cancelled”. Refund the total price amount of current order to user’s WalletBalance then return the food items of the current order to FoodList. 
                foreach (OrderDetails order in orderList)
                {
                    if (order.OrderID.Equals(orderID) && order.OrderStatus.Equals(OrderStatus.Ordered) && order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                    {
                        currentLoggedInUser.WalletRecharge(order.TotalPrice);
                        order.OrderStatus = OrderStatus.Cancelled;
                        flag = false;
                        foreach (ItemDetails item in itemList)
                        {
                            if (item.OrderID.Equals(orderID))
                            {
                                tempItemList.Add(item);
                            }
                        }
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Invalid Order ID or order not found");
                }
                else
                {
                    ReturnFood(tempItemList);
                    Console.WriteLine("Order cancelled successfully. Amount will be refunded to your wallet.");
                }
            }


        }//cancel order ends

        //Modify order
        public static void ModifyOrder()
        {
            // a.	Show the orders placed by current logged in user whose order status is booked.
            int count = OrderedFoods();
            // b.	Ask OrderID to modify orders
            if (count > 0)
            {
                Console.Write("Enter the orderID you want to modify: ");
                string orderID = Console.ReadLine().ToUpper();
                // c.	Check OrderID is valid, and it is of current user’s and its status is Ordered. Then fetch the item details of corresponding order and show it.
                foreach (OrderDetails order in orderList)
                {
                    if (order.OrderID.Equals(orderID) && order.OrderStatus.Equals(OrderStatus.Ordered) && order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                    {
                        ShowItemDetails(orderID);
                        Console.Write("Enter the item ID to modify: ");
                        // d.	Ask ItemID and check ItemID is valid. Then ask user to provide new item quantity.
                        string itemID = Console.ReadLine().ToUpper();
                        bool flag = true;
                        foreach (ItemDetails item in itemList)
                        {
                            if (itemID.Equals(item.ItemID) && item.OrderID.Equals(orderID))
                            {
                                flag=false;
                                Console.Write("Enter the modified quantity of the item: ");
                                bool tempQuantity=int.TryParse(Console.ReadLine(),out int quantity);
                                while(!tempQuantity||quantity<0)
                                {
                                    Console.Write("Enter a valid Quantity: ");
                                    tempQuantity=int.TryParse(Console.ReadLine(),out  quantity);
                                }
                                int pastQuantity = item.PurchaseCount;
                                int difference = quantity - pastQuantity;
                                double differencePrice = 0;
                                bool modification = false;
                                foreach (FoodDetails food in foodList)
                                {
                                    if (item.FoodID.Equals(food.FoodID))
                                    {
                                        if (food.QuantityAvailable >= difference)
                                        {
                                            differencePrice = difference * food.PricePerQuantity;
                                            if (difference > 0)
                                            {
                                                if (currentLoggedInUser.WalletBalance >= differencePrice)
                                                {
                                                    modification = true;
                                                    currentLoggedInUser.DeductBalance(differencePrice);

                                                }
                                                else
                                                {
                                                // f.	If item quantity increased, then item amount will be collected from current user if he has enough balance. If he has no balance, ask him to recharge with that amount and proceed. If the item quantity reduced, then balance amount should be returned to current user.
                                                    Console.WriteLine("Insufficient Balance");
                                                    Console.Write("Enter yes if you wish to recharge and continue: ");
                                                    string isRecharge = Console.ReadLine().ToLower();
                                                    if (isRecharge.Equals("yes"))
                                                    {
                                                        Console.Write("Enter the amount to recharge: ");
                                                        bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
                                                        while(!tempAmount||amount<1)
                                                        {
                                                            Console.Write("Please enter a valid amount: ");
                                                            tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                                                        }
                                                        currentLoggedInUser.WalletRecharge(amount);
                                                        while (currentLoggedInUser.WalletBalance < differencePrice)
                                                        {
                                                            Console.Write("Insufficient balance.Enter the amount to recharge");
                                                            tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                                                            while(!tempAmount||amount<1)
                                                            {
                                                                Console.Write("Please enter a valid amount: ");
                                                                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
                                                            }
                                                            currentLoggedInUser.WalletRecharge(amount);
                                                        }
                                                        modification = true;
                                                        currentLoggedInUser.DeductBalance(differencePrice);

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Order modificationexited due to insufficient balance.");
                                                    }
                                                }
                                            }
                                            else if(difference<0)
                                            {
                                                modification=true;
                                                currentLoggedInUser.WalletRecharge(Math.Abs(differencePrice));
                                                Console.WriteLine("Your amount will be refunded to your wallet");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Required Quantity not available.\nExiting to the service menu");
                                        }

                                        // e.	Based on new item quantity the item object needs to be updated its price.

                                        if (modification)
                                        {
                                            food.QuantityAvailable -= difference;
                                            item.PurchaseCount = quantity;
                                            order.TotalPrice += differencePrice;
                                            item.PriceOfOrder += differencePrice;
                                            Console.WriteLine($"OrderID:{orderID} Modified succeesfully");
                                        }
                                        break;
                                    }
                                }

                                break;
                            }
                        }
                        if (flag)
                        {
                            Console.WriteLine("Item ID invalid or item not found");
                        }
                       break;

                    }
                }
                
                // g.	Update the total amount of order and show “Order ID + (OID3001) + modified successfully”.

            }

        }//ModifyOrder ends

        //OrderedFoods
        public static int OrderedFoods()
        {
            int count = 0;
            Console.WriteLine($"|{"Order ID",-10}|{"Customer ID",-10}|{"Total Price",-10}|{"Date of Order",-14}|{"OrderStatus",-14}|");
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    flag = false;
                    count++;
                    Console.WriteLine($"|{order.OrderID,-10}|{order.CustomerID,-10}|{order.TotalPrice,-10}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-10}|");
                }
            }
            if (flag)
            {
                Console.WriteLine("No order found");
            }
            return count;
        }

        //Order History
        public static void OrderHistory()
        {
            Console.WriteLine($"|{"Order ID",-10}|{"Customer ID",-10}|{"Total Price",-10}|{"Date of Order",-14}|{"OrderStatus",-14}|");
            bool flag = true;
            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID.Equals(currentLoggedInUser.CustomerID))
                {
                    flag = false;
                    Console.WriteLine($"|{order.OrderID,-10}|{order.CustomerID,-10}|{order.TotalPrice,-10}|{order.DateOfOrder.ToString("dd/MM/yyyy"),-15}|{order.OrderStatus,-10}|");
                }
            }
            if (flag)
            {
                Console.WriteLine("No order History");
            }
        }//OrderHistory ends

        //Recharge Wallet
        public static void RechargeWallet()
        {
            Console.Write("Enter the amount you want to recharge(inrupees): ");
            bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
            while(!tempAmount||amount<1)
            {
                Console.Write("Please enter a valid amount: ");
                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Wallet recharge successful.Your current balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//Recharge wallet ends

        //show wallet balance
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"your current Wallet Balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//show Wallet balance ends


        //show item list
        public static void ShowItemDetails(string orderID)
        {
            Console.WriteLine("|Item ID|Order ID|Food ID|Purchase Count|Price Of Order|");
            foreach (ItemDetails item in itemList)
            {
                if (orderID.Equals(item.OrderID))
                {
                    Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.PurchaseCount,-10}|{item.PriceOfOrder,-10}|");
                }
            }
        }
        //showing food details
        public static void ShowFoodDetails()
        {
            Console.WriteLine("|Food ID|Food Name|Price Per Quantity|Quantity Available|");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"|{food.FoodID,-10}|{food.FoodName,-12}|{food.PricePerQuantity,13}|{food.QuantityAvailable,-13}|");
            }
        }

        //calcuatle total price
        public static double CalculateTotalPrice(CustomList<ItemDetails> tempItemList)
        {
            double totalPrice = 0;
            foreach (ItemDetails item in tempItemList)
            {
                totalPrice += item.PriceOfOrder;
            }
            return totalPrice;
        }

        //return the item to the food list
        public static void ReturnFood(CustomList<ItemDetails> tempItemList)
        {
            foreach (ItemDetails item in tempItemList)
            {
                foreach (FoodDetails food in foodList)
                {
                    if (food.FoodID.Equals(item.FoodID))
                    {
                        food.QuantityAvailable += item.PurchaseCount;
                        break;
                    }
                }
            }
        }



        //Adding default data
        // public static void AddDefaultData()
        // {
        //     CustomerDetails customer1 = new CustomerDetails("Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai", 10000);
        //     CustomerDetails customer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai", 15000);
        //     customerList.AddRange(new CustomList<CustomerDetails> { customer1, customer2 });

        //     FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
        //     FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
        //     FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
        //     FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
        //     FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
        //     FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
        //     FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
        //     FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
        //     FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
        //     FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
        //     FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
        //     foodList.AddRange(new CustomList<FoodDetails> { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11 });

        //     OrderDetails order1 = new OrderDetails(customer1.CustomerID, 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
        //     OrderDetails order2 = new OrderDetails(customer2.CustomerID, 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
        //     OrderDetails order3 = new OrderDetails(customer1.CustomerID, 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
        //     orderList.AddRange(new CustomList<OrderDetails> { order1, order2, order3 });

        //     ItemDetails item1 = new ItemDetails(order1.OrderID, food1.FoodID, 2, 200);
        //     ItemDetails item2 = new ItemDetails(order1.OrderID, food2.FoodID, 2, 300);
        //     ItemDetails item3 = new ItemDetails(order1.OrderID, food3.FoodID, 1, 80);
        //     ItemDetails item4 = new ItemDetails(order2.OrderID, food1.FoodID, 1, 100);
        //     ItemDetails item5 = new ItemDetails(order2.OrderID, food3.FoodID, 4, 600);
        //     ItemDetails item6 = new ItemDetails(order2.OrderID, food10.FoodID, 1, 120);
        //     ItemDetails item7 = new ItemDetails(order2.OrderID, food9.FoodID, 1, 50);
        //     ItemDetails item8 = new ItemDetails(order3.OrderID, food2.FoodID, 2, 300);
        //     ItemDetails item9 = new ItemDetails(order3.OrderID, food8.FoodID, 4, 320);
        //     ItemDetails item10 = new ItemDetails(order3.OrderID, food1.FoodID, 2, 200);
        //     itemList.AddRange(new CustomList<ItemDetails> { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
        // }//default data ends
    }
}