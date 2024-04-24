using System;

namespace Cafeteria
{
    /// <summary>
    /// Class Operations used to create instance for Operations that had to gone on an application <see cref="Operations"/> 
    /// </summary>
    public static class Operations
    {
        static string line = "------------------------------------";
        public static UserDetails currentLoggedInUser;
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();

        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<CartItem> cartItemList = new CustomList<CartItem>();

        /// <summary>
        /// Method mainmenu for the initiation of the application of the instance of <see cref="Operations"/>
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("              Cafeteria           ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            string mainOption = "yes";
            do
            {
                Console.WriteLine("_____________Main Menu______________");
                Console.WriteLine("Select an Option\n1. user Registration\n2. User Login\n3. Exit");
                Console.Write("Enter the Option: ");
                bool tempMainChoice = int.TryParse(Console.ReadLine(), out int mainChoice);
                while (!tempMainChoice || mainChoice > 3 || mainChoice < 1)
                {
                    Console.WriteLine("Invalid Option");
                    Console.Write("Please enter a valid Option: ");
                    tempMainChoice = int.TryParse(Console.ReadLine(), out mainChoice);
                }
                switch (mainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("        User Registration");
                            Console.WriteLine(line);
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("           User Login");
                            Console.WriteLine(line);
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Application exited successfully");
                            mainOption = "no";
                            break;
                        }
                }
            } while (mainOption == "yes");
        }
        //Registration
        /// <summary>
        /// Method Registration  is for the  registration of an user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void UserRegistration()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter your Gender(Male/Female/Transgender): ");
            bool tempGender = Enum.TryParse<Gender>(Console.ReadLine(), true, out Gender gender);
            while (!tempGender)
            {
                Console.Write("Please Enter a valid Gender(Male/Female/Transgender): ");
                tempGender = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);
            }
            Console.Write("Enter your Mobile Number: ");
            string mobileNumber = Console.ReadLine();
            Console.Write("Enter your mail ID: ");
            string mailID = Console.ReadLine();
            Console.Write("Enter your Workstation number: ");
            string WorkStationNumber = Console.ReadLine().ToUpper();
            while (!WorkStationNumber.Contains("WS"))
            {
                Console.WriteLine("Invalid Workstation Number");
                Console.Write("Enter a valid Workstation number: ");
                WorkStationNumber = Console.ReadLine().ToUpper();
            }
            Console.Write("Enter the initial amount (in Rupees): ");
            bool tempBalance = double.TryParse(Console.ReadLine(), out double balance);
            while (!tempBalance || balance <= 0)
            {
                Console.Write("Please enter a valid amount(in rupees): ");
                tempBalance = double.TryParse(Console.ReadLine(), out balance);
            }
            UserDetails user = new UserDetails(name, fatherName, gender, mobileNumber, mailID, WorkStationNumber, balance);
            userList.Add(user);
            Console.WriteLine(line);
            Console.WriteLine($"Registration Successful.User ID: {user.UserID}");
            Console.WriteLine(line);
        }//Registration ends

        //Login
        /// <summary>
        /// Method UserLogin  is for the User to login to his account of the instance of <see cref="Operations"/>
        /// </summary>
        public static void UserLogin()
        {
            Console.Write("Enter your User ID: ");
            string loginID = Console.ReadLine().ToUpper();
            bool login = false;
            foreach (UserDetails user in userList)
            {
                if (user.UserID.Equals(loginID))
                {
                    Console.WriteLine("Logged In Successfully");
                    Console.WriteLine($"Welcome  {user.Name}.......");
                    login = true;
                    currentLoggedInUser = user;
                    SubMenu();
                }

            }
            if (!login)
            {
                Console.WriteLine("Invalid User ID or User ID not found");
            }
        }//Login ends
        //submenu
        /// <summary>
        /// Method SubMenu  is for  showing the options to the  user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void SubMenu()
        {
            string subOption = "yes";
            do
            {
                Console.WriteLine("_______________Sub Menu______________");
                Console.WriteLine("Select an Option\n1. Show My Profile\n2. FoodOrder\n3. Modify Order\n4. Cancel Order\n5. Order History\n6. Wallet Recharge\n7. Show Wallet Balance\n8. Exit");
                Console.Write("Enter an Option: ");
                bool tempSubChoice = int.TryParse(Console.ReadLine(), out int subChoice);
                while (!tempSubChoice || subChoice > 8 || subChoice < 1)
                {
                    Console.WriteLine("Invalid Option");
                    Console.Write("Please Enter a valid Option: ");
                    tempSubChoice = int.TryParse(Console.ReadLine(), out subChoice);
                }
                switch (subChoice)
                {
                    case 1:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       My Profile   ");
                            Console.WriteLine(line);
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Food Order   ");
                            Console.WriteLine(line);
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Modify Order   ");
                            Console.WriteLine(line);
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Cancel Order   ");
                            Console.WriteLine(line);
                            CancelOrder();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Order History   ");
                            Console.WriteLine(line);
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Wallet Recharge   ");
                            Console.WriteLine(line);
                            WalletRecharge();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("       Wallet Balance   ");
                            Console.WriteLine(line);
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Taking back to Main Menu");
                            subOption = "no";
                            break;
                        }
                }
            } while (subOption == "yes");
        }//sub menu ends

        //show my profile
        /// <summary>
        /// method ShowMyProfile is for showing the user details to them of the instance of <see cref="Operations"/>
        /// </summary>
        public static void ShowMyProfile()
        {
            Console.WriteLine($"UserID: {currentLoggedInUser.UserID}\nUser Name: {currentLoggedInUser.Name}\nFather Name: {currentLoggedInUser.FatherName}\nGender: {currentLoggedInUser.Gender}\nMobile Number: {currentLoggedInUser.Mobile}\nMail ID: {currentLoggedInUser.MailID}\nWorkstation Number: {currentLoggedInUser.WorkStationNumber}");
        }//show my profile ends

        //food order
        /// <summary>
        /// method FoodOrder is for ordering the food for the user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void FoodOrder()
        {
            // 1.	Create a temporary local carItemtList.
            CustomList<CartItem> tempList = new CustomList<CartItem>();
            // 2.	Create an Order object with current UserID, Order date as current DateTime, total price as 0, Order status as “Initiated”.
            OrderDetails order = new OrderDetails(currentLoggedInUser.UserID, DateTime.Now, 0, OrderStatus.Initiated);
            // 3.	Ask the user to pick a product using FoodID, quantity required and calculate price of food.
            string option = "no";
            bool isPresent = false;
            do
            {
                isPresent=false;
                ShowFood();
                Console.Write("Enter the FoodID you want to order: ");
                string foodID = Console.ReadLine().ToUpper();
                foreach (FoodDetails food in foodList)
                {
                    if (food.FoodID.Equals(foodID))
                    {
                        isPresent = true;
                        // 4.	If the food and quantity available, reduce the quantity from the food object’s “AvailableQuantity” then create CartItems object using the available data.
                        Console.Write("Enter the Quantity you want: ");
                        bool tempQuantity = int.TryParse(Console.ReadLine(), out int quantity);
                        while (!tempQuantity || quantity < 1)
                        {
                            Console.Write("Please enter a valid number: ");
                            tempQuantity = int.TryParse(Console.ReadLine(), out quantity);
                        }
                        if (food.FoodQuantity >= quantity)
                        {
                            // 5.	Add that object it to local CartItemsList to add it to cart wish list.
                            CartItem item = new CartItem(order.OrderID, food.FoodID, food.FoodPrice * quantity, quantity);
                            tempList.Add(item);
                            food.FoodQuantity -= quantity;
                            // 6.	Ask the user whether he want to pick another product. 
                            Console.Write("Enter yes if you want to pick another product: ");
                            option = Console.ReadLine().ToLower();
                            // 7.	If “Yes” then show the updated Food Details and repeat from step “3”.
                            // 8.	Repeat the process until the user enters “No”.
                        }
                        else
                        {
                            Console.WriteLine("Specified quantity not available");
                            Console.Write("Enter yes if you want to pick another product: ");
                            option = Console.ReadLine().ToLower();

                        }
                        break;
                    }
                }
                if (!isPresent || (!isPresent && tempList.Count > 0))
                {
                    Console.WriteLine("Invalid food ID or Food ID not found");
                    Console.Write("Enter yes if you want to pick another product: ");
                    option = Console.ReadLine().ToLower();
                }
            } while (option == "yes");
            // 9.	If He says No then, 
            // 10.	Ask the user whether he confirm the wish list to purchase. If he says “No” then traverse the local CartItemList and get the Items one by one and reverse the quantity to the FoodItem’s objects in the foodList.
            if (tempList.Count > 0)
            {
                string userWill = "yes";
                Console.Write("Enter yes to Confirm the order that added in the cart: ");
                string orderConfirmation = Console.ReadLine().ToLower();
                if (orderConfirmation.Equals("yes"))
                {
                    // 11.	If he says “Yes” then, Calculate the total price of the food items selected using the local CartItemList information and check the balance from the user details whether it has sufficient balance to purchase.
                    double totalPrice = CalculateTotalPrice(tempList);
                    Console.WriteLine($"The totak price of your order is {totalPrice}");
                    if (currentLoggedInUser.WalletBalance >= totalPrice)
                    {
                        // 12.	If he has enough balance, then deduct the respective amount from the user’s balance. 
                        currentLoggedInUser.DeductAmount(totalPrice);
                        // 13.	Append the local CartItemList to global CartItemList.
                        cartItemList.AddRange(tempList);
                        // 14.	Modify Order object created at step 1’s total price as total OrderPrice and OrderStatus as “Ordered”. 
                        order.TotalPrice = totalPrice;
                        order.OrderStatus = OrderStatus.Ordered;
                        // 15.	Then add the Order object to the Order list.
                        orderList.Add(order);
                        // 16.	Show “Order placed successfully, and OrderID is OID1001”.
                        Console.WriteLine($"Order placed successfully. OrderID is {order.OrderID}");
                    }
                    else
                    {
                        // 17.	If he doesn’t have enough balance show “In sufficient balance to purchase.” Ask him “Are you willing to recharge.”
                        Console.WriteLine("In sufficient balance to purchase.");
                        Console.WriteLine($"Recharge Rs.{totalPrice - currentLoggedInUser.WalletBalance} to confirm your order");
                        Console.Write("Are you willing to recharge (yes/no): ");
                        userWill = Console.ReadLine().ToLower();
                        if (userWill == "yes")
                        {
                            // 19.	If he says “Yes”. Then ask him to Recharge with the total price of Order. If he recharged with that amount means continue from step 12 to continue purchase. 
                            currentLoggedInUser.WalletRecharge(totalPrice - currentLoggedInUser.WalletBalance);
                            currentLoggedInUser.DeductAmount(totalPrice);
                            cartItemList.AddRange(tempList);
                            order.TotalPrice = totalPrice;
                            order.OrderStatus = OrderStatus.Ordered;
                            orderList.Add(order);
                            Console.WriteLine($"Order placed successfully. OrderID is {order.OrderID}");
                        }
                        else
                        {
                            // 18.	 If he says “No” then show “Exiting without Order due to insufficient balance”. Then need to return the localCartList items to foodItemsList.
                            Console.WriteLine("Exiting without Order due to insufficient balance");
                        }

                    }

                }
                if (userWill != "yes" || orderConfirmation != "yes")
                {
                    ReturnProduct(tempList);
                }
            }



        }//food order ends

        //modify order
        /// <summary>
        /// method ModifyOrder is for modifying the order placed by the user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void ModifyOrder()
        {
            // 1.	Show the Order details of current logged in user to pick an Order detail by using OrderID and whose status is “Ordered”. Check whether the order details is present. If yes then,
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"|{"Order ID",-10}|{"User ID",-10}|{"Order Date",-10}|{"Total Price",-10}|{"Order Status",-10}|");
            Console.WriteLine("-----------------------------------------------------------");
            bool flag = true;
            foreach (OrderDetails orders in orderList)
            {
                if (orders.UserID.Equals(currentLoggedInUser.UserID)&&orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    flag = false;
                    Console.WriteLine($"|{orders.OrderID,-10}|{orders.UserID,-10}|{orders.OrderDate.ToString("dd/MM/yyyy"),-10}|{orders.TotalPrice,-11}|{orders.OrderStatus,-12}|");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
            if (!flag)
            {
                Console.Write("Enter the OrderID you want to modify: ");
                string orderID = Console.ReadLine().ToUpper();
                bool isPresent = CorrectID(orderID);
                // 2.	Show list of Cart Item details and ask the user to pick an Item id.
               
                    if (isPresent)
                    {
                        int count = ShowCartItems(orderID);
                        isPresent = true;
                        bool validID = false;
                        if (count > 0)
                        {
                            Console.Write("Enter the item ID you want to modify: ");
                            string itemID = Console.ReadLine().ToUpper();
                            foreach (CartItem item in cartItemList)
                            {
                                if (itemID.Equals(item.ItemID)&& orderID.Equals(item.OrderID))
                                {
                                    validID = true;
                                    Console.Write("Enter the new quantity you want to modify: ");
                                    bool tempQuantity = int.TryParse(Console.ReadLine(), out int quantity);
                                    while (!tempQuantity || quantity < 0)
                                    {
                                        Console.Write("Please enter a valid quantity: ");
                                        tempQuantity = int.TryParse(Console.ReadLine(), out quantity);
                                    }
                                    int pastQuantity = item.OrderQuantity;
                                    double pastPrice = item.OrderPrice;
                                    item.OrderQuantity = quantity;
                                    int difference = quantity - pastQuantity;
                                    double foodPrice = 0;
                                    int totalQuantity=0;
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (food.FoodID.Equals(item.FoodID)&&food.FoodQuantity>=difference)
                                        {
                                            totalQuantity=food.FoodQuantity;
                                            foodPrice = food.FoodPrice;
                                            item.OrderPrice = quantity * food.FoodPrice;
                                            food.FoodQuantity -= difference;
                                            break;
                                        }
                                    }
                                    double totalPrice=0;
                                    if(totalQuantity>=difference)
                                    { 
                                        if (difference < 0)
                                        {
                                            int reduceddifference = Math.Abs(difference);
                                            currentLoggedInUser.WalletRecharge(foodPrice * reduceddifference);
                                            totalPrice+=pastPrice-(reduceddifference*foodPrice);
                                            ReturnMoney(orderID,totalPrice);
                                            Console.WriteLine("The balance amount is refunded to your wallet");
                                        }
                                        else if (difference > 0)
                                        {
                                            Console.WriteLine($"You have to pay Rs.{difference * foodPrice} since you increased the difference");
                                            if (currentLoggedInUser.WalletBalance >= difference * foodPrice)
                                            {
                                                currentLoggedInUser.DeductAmount(difference * foodPrice);
                                                totalPrice+=difference*foodPrice;
                                                ReturnMoney(orderID,totalPrice);
                                                Console.WriteLine("Order modified successfully");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Insufficient balance");
                                                Console.Write("Enter yes if you want to recharge and modify the order: ");
                                                string userWill = Console.ReadLine().ToLower();
                                                if (userWill == "yes")
                                                {
                                                    currentLoggedInUser.DeductAmount(currentLoggedInUser.WalletBalance);
                                                    totalPrice+=difference*foodPrice;
                                                    ReturnMoney(orderID,totalPrice);

                                                    Console.WriteLine("Order modified successfully");
                                                }
                                                else
                                                {
                                                    item.OrderQuantity = pastQuantity;
                                                    item.OrderPrice = pastPrice;
                                                    foreach (FoodDetails food in foodList)
                                                    {
                                                        if (food.FoodID.Equals(item.FoodID))
                                                        {
                                                            food.FoodQuantity-=difference;
                                                        }
                                                    }
                                                    Console.WriteLine("Order modification exited due to insufficient balance");
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Specified quantitiy not available");
                                    }

                                    break;
                                }

                            }
                        }
                        if(!validID)
                        {
                            Console.WriteLine("Item ID invalid or item ID not found");
                        }
                        
                    }
                
                if(!isPresent)
                {
                    Console.WriteLine("Order ID invalid or not found");
                }

                // 3.	Ensure the ItemID is available and ask the user to enter the new quantity of the food. Calculate the Item price and update in the OrderPrice.
                // 4.	Calculate the total price of Items and update in Order details entry. 
                // 5.	Show Order modified successfully.

            }
            else 
            {
                Console.WriteLine("No orders to modify");
            }
        }//modify order ends
        
         //cancel order
         /// <summary>
         /// method CancelOrder is for cancelling the order place by the user of the instance of <see cref="Operations"/>
         /// </summary>
        public static void CancelOrder()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"|{"Order ID",-10}|{"User ID",-10}|{"Order Date",-10}|{"Total Price",-10}|{"Order Status",-10}|");
            Console.WriteLine("-----------------------------------------------------------");
            bool flag = true;
            foreach (OrderDetails orders in orderList)
            {
                if (orders.UserID.Equals(currentLoggedInUser.UserID)&&orders.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    
                    flag = false;
                    Console.WriteLine($"|{orders.OrderID,-10}|{orders.UserID,-10}|{orders.OrderDate.ToString("dd/MM/yyyy"),-10}|{orders.TotalPrice,-11}|{orders.OrderStatus,-12}|");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
            
            if (!flag)
            {
                Console.Write("Enter the Order ID you want to cancel: ");
                string orderID = Console.ReadLine().ToUpper();
                if (!CorrectID(orderID))
                {
                    Console.WriteLine("OrderID invalid or orderID not found");
                }
                else
                {
                    foreach (OrderDetails order in orderList)
                    {
                        if (orderID.Equals(order.OrderID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                        {
                            order.OrderStatus = OrderStatus.Cancelled;
                            currentLoggedInUser.WalletRecharge(order.TotalPrice);
                            Console.WriteLine("Order cancelled successfully");
                            foreach (CartItem item in cartItemList)
                            {
                                if (item.OrderID.Equals(orderID))
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (item.FoodID.Equals(food.FoodID))
                                        {
                                            food.FoodQuantity += item.OrderQuantity;
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                Console.WriteLine("No ordered products found");
            }
        }//cancel order ends

        //return money
        /// <summary>
        /// Method return money for returning the total price to the order details of the instance of <see cref="Operations"/>
        /// </summary>
        /// <param name="orderID">for getting the correct order details</param>
        /// <param name="amount">total price of ordered products </param>
        public static void ReturnMoney(string orderID,double amount)
        {
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID.Equals(orderID))
                {
                    order.TotalPrice+=amount;
                }
            }
        }
        //checking orderid correct
        /// <summary>
        /// method correctID is for checking the orderid entered by the user is present or not and the order is belong to the same userID of the instance of <see cref="Operations"/> 
        /// </summary>
        /// <param name="orderID">OrderId given by user</param>
        public static bool CorrectID(string orderID)
        {
            foreach (OrderDetails order in orderList)
            {
                if(order.OrderID.Equals(orderID)&&order.UserID.Equals(currentLoggedInUser.UserID))
                {
                    return true;
                }
            }
            return false;
        }
        //cartitems showing
        /// <summary>
        /// method ShowCartItems is for showing the items in the cart of the specific orderid of the instance of <see cref="Operations"/>
        /// </summary>
        /// <param name="orderID">orderID given by user</param>
        /// <returns>count of orders with ordered status</returns>
        public static int ShowCartItems(string orderID)
        {
            int count = 0;
            bool ordered=false;
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderStatus.Equals(OrderStatus.Ordered)&& order.OrderID.Equals(orderID))
                {
                    ordered=true;
                    break;
                }
            }
            if(ordered)
            {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine($"|{"Item ID",-10}|{"Order ID",-10}|{"Food ID",-10}|{"Order Price",-10}|{"Order Quantity",-10}|");
            Console.WriteLine("-------------------------------------------------------------");
                foreach (CartItem item in cartItemList)
                {
                    if (item.OrderID.Equals(orderID))
                    {
                        count++;
                        Console.WriteLine($"|{item.ItemID,-10}|{item.OrderID,-10}|{item.FoodID,-10}|{item.OrderPrice,-11}|{item.OrderQuantity,-15}|");
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                }
            }
            return count;
        }

        //orderHistory
        /// <summary>
        /// OrderHistory for showing the history of the order made by the user of the instance of <see cref="Operations"/>
        /// </summary>
        public static int OrderHistory()
        {
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"|{"Order ID",-10}|{"User ID",-10}|{"Order Date",-10}|{"Total Price",-10}|{"Order Status",-10}|");
            Console.WriteLine("-----------------------------------------------------------");
            bool flag = true;
            int count = 0;
            foreach (OrderDetails orders in orderList)
            {
                if (orders.UserID.Equals(currentLoggedInUser.UserID))
                {
                    if(orders.OrderStatus.Equals(OrderStatus.Ordered))
                    {
                        count++;
                    }
                    flag = false;
                    Console.WriteLine($"|{orders.OrderID,-10}|{orders.UserID,-10}|{orders.OrderDate.ToString("dd/MM/yyyy"),-10}|{orders.TotalPrice,-11}|{orders.OrderStatus,-12}|");
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }
            if (flag)
            {
                Console.WriteLine("No orders to display");
            }
            return count;
        }//order history ends

        //wallet recharge
        /// <summary>
        /// WalletRecharge method is for getting the amount to be recharged from the user and add them to their balance of the instance of <see cref="Operations"/>
        /// </summary>
        public static void WalletRecharge()
        {
            Console.Write("Enter yes if you want to recharge: ");
            string choice = Console.ReadLine().ToLower();
            if (choice == "yes")
            {
                Console.Write("Enter the amount to recharge(in rupees): ");
                bool tempAmount = double.TryParse(Console.ReadLine(), out double amount);
                while (!tempAmount)
                {
                    Console.Write("Please enter a valid amount(in rupees): ");
                    tempAmount = double.TryParse(Console.ReadLine(), out amount);
                }
                currentLoggedInUser.WalletRecharge(amount);
                Console.WriteLine($"Recharge successful.Current Balance is Rs.{currentLoggedInUser.WalletBalance}");
            }
        }//wallet recharge ends

        //walletBalance
        /// <summary>
        /// ShowWalletBalance method is for showing the Wallet Balance of the login user of the instance of <see cref="Operations"/>
        /// </summary>
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your current WalletBalance is {currentLoggedInUser.WalletBalance}");
        }//wallet balance ends

        //return product
        /// <summary>
        /// Return Product is for returning the product from the temprary cartitemlist if they do not have enough money or not want to confirm the order of the instance of <see cref="Operations"/>
        /// </summary>
        /// <param name="list">the temparary list</param>
        public static void ReturnProduct(CustomList<CartItem> list)
        {
            foreach (CartItem item in list)
            {
                foreach (FoodDetails food in foodList)
                {
                    if (food.FoodID.Equals(item.FoodID))
                    {
                        food.FoodQuantity += item.OrderQuantity;
                    }
                }
            }
        }

        //totalprice
        /// <summary>
        /// Calculate Total Price method for calculating the total price of the products present in the temparary cartItem list of the instance of <see cref="Operations"/>
        /// </summary>
        /// <param name="list">the temparary list</param>
        public static double CalculateTotalPrice(CustomList<CartItem> list)
        {
            double amount = 0;
            foreach (CartItem item in list)
            {
                amount += item.OrderPrice;
            }
            return amount;
        }//total price ends

        //show food Details
        /// <summary>
        /// ShowFood method for showing the food availability to the user during foodOrder of the instance of <see cref="Operations"/>
        /// </summary>
        public static void ShowFood()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"|{"Food ID",-10}|{"Food Name",-10}|{"Price",-5}|{"Available Quantity",-15}|");
            Console.WriteLine("------------------------------------------------");
            foreach (FoodDetails food in foodList)
            {
                Console.WriteLine($"|{food.FoodID,-10}|{food.FoodName,-10}|{food.FoodPrice,-5}|{food.FoodQuantity,-18}|");
                Console.WriteLine("------------------------------------------------");
            }
        }
        //Adding default data
        // public static void AddDefaultData()
        // {
        //     FoodDetails food1 = new FoodDetails("Cofee", 20, 100);
        //     FoodDetails food2 = new FoodDetails("Tea", 15, 100);
        //     FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
        //     FoodDetails food4 = new FoodDetails("Juice", 50, 100);
        //     FoodDetails food5 = new FoodDetails("Puff", 40, 100);
        //     FoodDetails food6 = new FoodDetails("Milk", 10, 100);
        //     FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
        //     foodList.AddRange(new CustomList<FoodDetails> { food1, food2, food3, food4, food5, food6, food7 });



        //     UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", Gender.Male, "8857777575", "ravi@gmail.com", "WS101", 400);
        //     UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", Gender.Male, "9577747744", "baskaran@gmail.com", "WS105", 500);
        //     userList.Add(user1);
        //     userList.Add(user2);

        //     OrderDetails order1 = new OrderDetails(user1.UserID, new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
        //     OrderDetails order2 = new OrderDetails(user2.UserID, new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);
        //     orderList.Add(order1);
        //     orderList.Add(order2);

        //     CartItem item1 = new CartItem(order1.OrderID, food1.FoodID, food1.FoodPrice, 1);
        //     CartItem item2 = new CartItem(order1.OrderID, food3.FoodID, food3.FoodPrice, 1);
        //     CartItem item3 = new CartItem(order1.OrderID, food5.FoodID, food5.FoodPrice, 1);
        //     CartItem item4 = new CartItem(order2.OrderID, food3.FoodID, food3.FoodPrice, 1);
        //     CartItem item5 = new CartItem(order2.OrderID, food4.FoodID, food4.FoodPrice, 1);
        //     CartItem item6 = new CartItem(order2.OrderID, food5.FoodID, food5.FoodPrice, 1);
        //     cartItemList.AddRange(new CustomList<CartItem> { item1, item2, item3, item4, item5, item6 });

        // }
    }
}