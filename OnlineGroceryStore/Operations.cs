using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public static class Operations
    {
        
        public static CustomList<CustomerRegistration>customerList=new CustomList<CustomerRegistration>();
        public static CustomList<ProductDetails> productList=new CustomList<ProductDetails>();
        public static CustomList<OrderDetails> orderList=new CustomList<OrderDetails>();
        public static CustomList<BookingDetails> bookingList=new CustomList<BookingDetails>();
        static CustomerRegistration currentLoggedInUser;
        
        //Main menu
        public static void MainMenu()
        {   
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("           Online Grocery Store            ");
            Console.WriteLine("-------------------------------------------");
            string mainMenuExit="no";
            do
            {
                Console.WriteLine("______________Main Menu______________");
                Console.WriteLine("Select an Option\n1. Customer Registration\n2. Customer Login\n3. Exit");
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
                        Console.WriteLine("          Customer Registration           ");
                        Console.WriteLine("-------------------------------------------");
                        Registration();
                        break;
                    }
                    case 2: 
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Customer Login            ");
                        Console.WriteLine("-------------------------------------------");
                        CustomerLogin();
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
        }//main menu ends

        //Customer Registration
        public static void Registration()
        {
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your father name: ");
            string fatherName=Console.ReadLine();
            Console.Write("Enter your Gender(Male/Female/Transgender): ");
            bool tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out Gender gender);
            while(!tempGender)
            {
                Console.Write("Enter a valid Gender(Male/Female/Transgender): ");
                tempGender=Enum.TryParse<Gender>(Console.ReadLine(),true,out  gender);
            }
            Console.Write("Enter your Mobile Number: ");
            string mobile=Console.ReadLine();
            Console.Write("Enter your DOB as specified (dd/MM/yyyy): ");
            bool tempDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out DateTime dob);
            while(!tempDOB)
            {
                Console.WriteLine("Invalid format");
                Console.Write("Please enter the DOB as specified (dd/MM/yyyy): ");
                tempDOB=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out  dob);
            }
            Console.Write("Enter your mail ID: ");
            string mailID=Console.ReadLine();
            Console.Write("Enter the initial amount you want to add to your wallet: ");
            bool tempBalance=double.TryParse(Console.ReadLine(),out double balance);
            while(!tempBalance||balance<0)
            {
                Console.Write("Enter a valid amount: ");
                tempBalance=double.TryParse(Console.ReadLine(),out  balance);
            }
            CustomerRegistration customer=new CustomerRegistration(name,fatherName,gender,mobile,dob,mailID,balance);
            customerList.Add(customer);
            Console.WriteLine($"Registration successful.Your CustomerID: {customer.CustomerID} "); 
        }//customer registration ends
        
        //Customer Login 
        public static void CustomerLogin()
        {
            Console.Write("Enter your customer ID: ");
            string loginID=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(CustomerRegistration customer in customerList)
            {
                if(customer.CustomerID.Equals(loginID))
                {

                    flag=false;
                    currentLoggedInUser=customer;
                    Console.WriteLine("Login Successful");
                    Console.WriteLine($"Welcome {currentLoggedInUser.Name}...");
                    SubMenu();
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Invalid Customer ID or Customer ID not found");
            }
        }//customerLogin

        //subMenu
        public static void SubMenu()
        {
            string subMenuExit="no";
            do
            {
                Console.WriteLine("______________Sub Menu_____________");
                Console.WriteLine("select an Option\n1. Show Customer Details\n2. Show Product Details\n3. Wallet Recharge\n4. Take Order\n5. Modify Order Quantity\n6. Cancel Order\n7. Show Balance\n8. Exit");
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
                        Console.WriteLine("              Customer Details            ");
                        Console.WriteLine("-------------------------------------------");
                        ShowCustomerDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Product Details            ");
                        Console.WriteLine("-------------------------------------------");
                        ShowProductDetails();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Wallet Recharge            ");
                        Console.WriteLine("-------------------------------------------");
                        WalletRecharge();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("                Take Order           ");
                        Console.WriteLine("-------------------------------------------");
                        TakeOrder();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("           Modify Order Quantity            ");
                        Console.WriteLine("-------------------------------------------");
                        ModifyOrderQuantity();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Cancel Order            ");
                        Console.WriteLine("-------------------------------------------");
                        CancelOrder();
                        break;
                    }
                    case 7:
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("              Wallet Balance           ");
                        Console.WriteLine("-------------------------------------------");
                        ShowBalance();
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

        //show Customer Details
        public static void ShowCustomerDetails()
        {
            Console.WriteLine($"Customer ID: {currentLoggedInUser.CustomerID}\nName: {currentLoggedInUser.Name}\nFather Name: {currentLoggedInUser.FatherName}\nGender: {currentLoggedInUser.Gender}\nMobile Number: {currentLoggedInUser.Mobile}\nDOB: {currentLoggedInUser.DOB.ToString("dd/MM/yyyy")}\nMail ID: {currentLoggedInUser.MailID}");
        }//show customer Details ends
        //show product details
        public static void ShowProductDetails()
        {
            ProductDetails.ShowProductDetails(productList);
        }

        //wallet recharge
        public static void WalletRecharge()
        {
            Console.Write("Enter the amount to recharge(in rupees): ");
            bool tempAmount=double.TryParse(Console.ReadLine(),out double amount);
            while(!tempAmount||amount<1)
            {
                Console.Write("Enter a valid amount: ");
                tempAmount=double.TryParse(Console.ReadLine(),out  amount);
            }
            currentLoggedInUser.WalletRecharge(amount);
            Console.WriteLine($"Recharge successful.\n Your current Balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//wallet Recharge ends

        //Take order
        public static void TakeOrder()
        {
            //Ask customer that whether he want to purchase / not. If “Yes” means Create booking details object with Customer id, Total price =0, Booking status = Initiated.
            //b.	Create a local order list named tempOrderList.
            CustomList<OrderDetails> tempOrderList=new CustomList<OrderDetails>();

            Console.Write("Enter yes if you want to purchase: ");
            string purchaseOption=Console.ReadLine().ToLower();
            BookingDetails booking=new BookingDetails(currentLoggedInUser.CustomerID,0,DateTime.Now,BookingStatus.Initiated);
            while(purchaseOption.Equals("yes"))
            {
                // c.	Show product details of available stock. 
                ShowProductDetails();
                //d.	Ask the user to select a product by using ProductID validate it, if it is ok then ask Purchase quantity else show “Invalid Product ID”.
                Console.Write("Enter the Product ID you want to purchase: ");
                string productID=Console.ReadLine().ToUpper();
                bool flag=true;
                foreach(ProductDetails product in productList)
                {
                    if(product.ProductID.Equals(productID))
                    {
                        int quantity=0;
                        flag=false;
                        if(product.QuantityAvailable>0)
                        {
                            Console.Write("Enter the quantity you want to purchase: ");
                            bool tempQuantity=int.TryParse(Console.ReadLine(),out quantity);
                            while(!tempQuantity||quantity<1)
                            {
                                Console.Write("Please Enter a valid quantity: ");
                                tempQuantity=int.TryParse(Console.ReadLine(),out quantity);
                            }
                        }
                        
                        // e.	Check whether the selected Purchase quantity is available in stock. 
                        if(product.QuantityAvailable>=quantity&&quantity>0)
                        {
                            // f.	If it is available means create order object with created BookingID, productID, quantity and price of order and store in tempOrder details list. Deduct the purchase count from product details. Calculate totalPurchaseAmount. And show Product successfully added to cart.
                            product.QuantityAvailable-=quantity;
                            OrderDetails order=new OrderDetails(booking.BookingID,product.ProductID,quantity,quantity*product.PricePerQuantity);
                            tempOrderList.Add(order);
                            // g.	Ask the customer whether he want to book another product. If “yes” means again show Product details and repeat step “C” to “f” create new order object. Repeat this process until he press “No”.
                            Console.Write("Enter yes if you want to purchase another product: ");
                            purchaseOption=Console.ReadLine().ToLower();

                        }
                        else
                        {
                            Console.WriteLine("Insufficient quantity");
                            Console.Write("Enter yes if you want to purchase another product: ");
                            purchaseOption=Console.ReadLine().ToLower();
                        }
                        break;
                    }
                }
                if(flag)
                {
                    Console.WriteLine("Invalid Product ID");
                    Console.Write("Enter yes if you want to purchase another product: ");
                    purchaseOption=Console.ReadLine().ToLower();
                }
            }
            // h.	After the above loop ask user Do you want to confirm the order.
            if(tempOrderList.Count>0)
            {
                Console.Write("Enter yes to confirm the order: ");
                string userwill=Console.ReadLine().ToLower();
                if(userwill.Equals("yes"))
                {
                    // i.	If he selects “yes” then check the user has enough balance. If he has it means deduct the totalPurchaseAmount from wallet. Update the booking status to Booked, update total price, and add the object to list. Add the tempOrderList to orderList. Show “Booking successful”.
                    double totalPrice=CalculateTotalPrice(tempOrderList);
                    if(currentLoggedInUser.WalletBalance>=totalPrice)
                    {
                        currentLoggedInUser.DeductAmount(totalPrice);
                        orderList.AddRange(tempOrderList);
                        booking.TotalPrice=totalPrice;
                        booking.BookingStatus=BookingStatus.Booked;
                        bookingList.Add(booking);
                        Console.WriteLine($"Booked successfully.Your Booking ID: {booking.BookingID}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance");
                        Console.Write($"Enter yes to recharge the remaining amount Rs.{totalPrice-currentLoggedInUser.WalletBalance} make the Booking: ");
                        string recharge=Console.ReadLine();
                        // j.	If he don’t have it means show “Insufficient account balance recharge with”+totalPurchaseAmount and proceed with recharge option. Repeat j step until he had enough balance.
                        if(recharge.Equals("yes"))
                        {
                            currentLoggedInUser.WalletRecharge(totalPrice-currentLoggedInUser.WalletBalance);
                            currentLoggedInUser.DeductAmount(totalPrice);
                            orderList.AddRange(tempOrderList);
                            booking.TotalPrice=totalPrice;
                            booking.BookingStatus=BookingStatus.Booked;
                            bookingList.Add(booking);
                            Console.WriteLine($"Booked successfully.Your Booking ID: {booking.BookingID}");
                        }
                        else
                        {
                            ReturnProduct(tempOrderList);
                            Console.WriteLine("Order Cancelled due to insufficient balance");
                        }
                    }

                }
                else
                {
                    ReturnProduct(tempOrderList);
                    Console.WriteLine("Cart removed successfully");
                }
            }
            
                        // k.	If user select “No” then traverse tempOrderList update product count to product detail list. And show cart removed successfully.
        }//Take order ends

        //Modify order
        public static void ModifyOrderQuantity()
        {
            // a.	Show the booking details of current logged in user to pick a booking detail by using BookingID and whose status is “Booked”. Check whether the booking details is present. If yes then,
            int noOfOrders=BookingDetails.ShowBookingDetails(bookingList,currentLoggedInUser.CustomerID);
            if(noOfOrders>0)
            {
                Console.Write("Enter the BookingID you want to modify: ");
                string bookingID=Console.ReadLine().ToUpper();
                bool isCorrectID=CheckBookingID(bookingID);
                if(isCorrectID)
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine($"|{"Order ID",-10}|{"Booking ID",-10}|{"Product ID",-10}|{"Purchase count",-10}|{"PriceOfOrder",-10}|");
                    Console.WriteLine("--------------------------------------------------------------");
                    // b.	Show list of order details and ask the user to pick an order id.
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.BookingID.Equals(bookingID))
                        {
                            Console.WriteLine($"|{order.OrderID,-10}|{order.BookingID,-10}|{order.ProductID,-10}|{order.PurchaseCount,-14}|{order.PriceOrder,-12}|");
                            Console.WriteLine("--------------------------------------------------------------");
                        }
                    }
                    Console.Write("Enter the Order ID you want to modify: ");
                    string orderID=Console.ReadLine().ToUpper();
                    bool flag=true;
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.OrderID.Equals(orderID)&&order.BookingID.Equals(bookingID))
                        {
                            flag=false;
                            Console.Write("Enter the modified quantity of the product: ");
                             bool tempQuantity=int.TryParse(Console.ReadLine(),out int quantity);
                            while(!tempQuantity||quantity<0)
                            {
                                Console.Write("Please Enter a valid quantity: ");
                                tempQuantity=int.TryParse(Console.ReadLine(),out quantity);
                            }
                            
                            int pastQuantity=order.PurchaseCount;
                            double pastPrice=order.PriceOrder;
                            int difference=quantity-pastQuantity;
                            double totalPrice=0;
                            double productPrice=0;
                            
                            foreach(ProductDetails product in productList)
                            {
                                if(order.ProductID.Equals(product.ProductID))
                                {
                                    if(difference>0)
                                    {
                                        productPrice=product.PricePerQuantity;
                                        if(difference<=product.QuantityAvailable)
                                        {
                                            totalPrice=difference*product.PricePerQuantity;
                                            if(currentLoggedInUser.WalletBalance>=totalPrice)
                                            { 
                                                Console.WriteLine($"RS.{totalPrice} is deducted from your wallet since you were increased the quantity by {difference}");
                                                currentLoggedInUser.DeductAmount(totalPrice);
                                                order.PriceOrder=quantity*product.PricePerQuantity;
                                                product.QuantityAvailable-=difference;
                                                order.PurchaseCount=quantity;
                                                ModifyPrice(difference,productPrice,bookingID);
                                                Console.WriteLine("Order modified successfully");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("Insufficient Balance");
                                                Console.WriteLine($"You have to recharge Rs.{totalPrice-currentLoggedInUser.WalletBalance} to modify the order");
                                                Console.Write("Enter yes to recharge: ");
                                                string recharge=Console.ReadLine().ToLower();
                                                if(recharge=="yes")
                                                {
                                                    currentLoggedInUser.DeductAmount(currentLoggedInUser.WalletBalance);
                                                    order.PriceOrder=quantity*product.PricePerQuantity;
                                                    product.QuantityAvailable-=difference;
                                                    order.PurchaseCount=quantity;
                                                    ModifyPrice(difference,productPrice,bookingID);
                                                    Console.WriteLine("Order modified successfully");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Order modification exited due to insuffiecient balance");
                                                }
                                            }
                                        }
                                    }
                                    else if(difference<0)
                                    {
                                        productPrice=product.PricePerQuantity;
                                        totalPrice=Math.Abs(difference)*product.PricePerQuantity;
                                        currentLoggedInUser.WalletRecharge(totalPrice);
                                        order.PriceOrder=quantity*product.PricePerQuantity;
                                        product.QuantityAvailable-=difference;
                                        order.PurchaseCount=quantity;
                                        ModifyPrice(difference,productPrice,bookingID);
                                        Console.WriteLine("Order modified successfully. The balance amount will be refunded to your wallet");
                                        
                                    }
                                    break;
                                }
                            }

                        }
                    }
                    // c.	Ensure the order ID is available and ask the user to enter the new quantity of the product. Calculate the order price and update in the order price.
                    // d.	Calculate the total price of order and update in booking details entry. 
                    // e.	Show order modified successfully.
                    if(flag)
                    {
                        Console.WriteLine("Order ID invalid or Order ID not found");
                    }

                }
                else
                {
                    Console.WriteLine("Booking ID invalid or Booking ID not found");
                }
            }
            else
            {
                Console.WriteLine("No booking was found to modify");
            }

        }//Modify Order ends

        //Cancel Order
        public static void CancelOrder()
        {
            CustomList<OrderDetails> tempOrderList=new CustomList<OrderDetails>();
            int noOfOrders=BookingDetails.ShowBookingDetails(bookingList,currentLoggedInUser.CustomerID);
            if(noOfOrders>0)
            {
                Console.Write("Enter the BookingID you want to modify: ");
                string bookingID=Console.ReadLine().ToUpper();
                bool isCorrectID=CheckBookingID(bookingID);
                if(isCorrectID)
                {
                    foreach(BookingDetails booking in bookingList)
                    {
                        if(booking.BookingID.Equals(bookingID))
                        {
                            booking.BookingStatus=BookingStatus.Cancelled;
                            currentLoggedInUser.WalletRecharge(booking.TotalPrice);
                            Console.WriteLine("Booking Cancelled successfully");
                            foreach(OrderDetails order in orderList)
                            {
                                if(order.BookingID.Equals(bookingID))
                                {
                                    tempOrderList.Add(order);
                                }
                            }
                        }
                    }
                    ReturnProduct(tempOrderList);
                }
                else
                {
                    Console.WriteLine("Booking ID invalid or Booking not found");
                }
            }
            else
            {
                Console.WriteLine("No booking made to cancel");
            }
        }//cancelOrder ends

        //ShowBalance
        public static void ShowBalance()
        {
            Console.WriteLine($"Your current Wallet Balance is Rs.{currentLoggedInUser.WalletBalance}");
        }//show balance ends

        //Modified price
        public static void ModifyPrice(int difference,double productPrice,string bookingID)
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(bookingID.Equals(booking.BookingID))
                {
                    booking.TotalPrice+=difference*productPrice;
                    break;
                }
            }
        }

        //return the product to the product details
        public static void ReturnProduct(CustomList<OrderDetails> tempOrderList)
        {
            foreach(OrderDetails order in tempOrderList)
            {
                foreach(ProductDetails product in productList)
                {
                    if(order.ProductID.Equals(product.ProductID))
                    {
                        product.QuantityAvailable+=order.PurchaseCount;
                    }
                }
            }
        }
        //Calculate TotalPrice
        public static double CalculateTotalPrice(CustomList<OrderDetails> tempOrderList)
        {
            double totalPrice=0;
            foreach(OrderDetails order in tempOrderList)
            {
                totalPrice+=order.PriceOrder;
            }
            return totalPrice;
        }
        
        //checking booking ID
        public static bool CheckBookingID(string bookingID)
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(bookingID)&&booking.BookingStatus.Equals(BookingStatus.Booked)&&currentLoggedInUser.CustomerID.Equals(booking.CustomerID))
                {
                    return true;
                }
            }
            return false;
        }


        //Adding default data
        // public static void AddDefaultData()
        // {
        //     CustomerRegistration customer1=new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com",10000);
        //     CustomerRegistration customer2=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com",15000);
        //     customerList.AddRange(new CustomList<CustomerRegistration> {customer1,customer2});

        //     ProductDetails product1=new ProductDetails("Sugar",20,40);
        //     ProductDetails product2=new ProductDetails("Rice",100,50);
        //     ProductDetails product3=new ProductDetails("Milk",10,40);
        //     ProductDetails product4=new ProductDetails("Coffee",10,10);
        //     ProductDetails product5=new ProductDetails("Tea",10,10);
        //     ProductDetails product6=new ProductDetails("Masala Powder",10,20);
        //     ProductDetails product7=new ProductDetails("Salt",10,10);
        //     ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
        //     ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
        //     ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
        //     productList.AddRange(new CustomList<ProductDetails>{product1,product2,product3,product4,product5,product6,product7,product8,product9,product10});

        //     BookingDetails booking1=new BookingDetails(customer1.CustomerID,220,new DateTime(2022,07,26),BookingStatus.Booked);
        //     BookingDetails booking2=new BookingDetails(customer2.CustomerID,400,new DateTime(2022,07,26),BookingStatus.Booked);
        //     BookingDetails booking3=new BookingDetails(customer1.CustomerID,280,new DateTime(2022,07,26),BookingStatus.Cancelled);
        //     BookingDetails booking4=new BookingDetails(customer2.CustomerID,0,new DateTime(2022,07,26),BookingStatus.Initiated);
        //     bookingList.AddRange(new CustomList<BookingDetails>{booking1,booking2,booking3,booking4});

        //     OrderDetails order1=new OrderDetails(booking1.BookingID,product1.ProductID,2,80);
        //     OrderDetails order2=new OrderDetails(booking1.BookingID,product2.ProductID,2,100);
        //     OrderDetails order3=new OrderDetails(booking1.BookingID,product3.ProductID,1,40);
        //     OrderDetails order4=new OrderDetails(booking2.BookingID,product1.ProductID,1,40);
        //     OrderDetails order5=new OrderDetails(booking2.BookingID,product2.ProductID,4,200);
        //     OrderDetails order6=new OrderDetails(booking2.BookingID,product10.ProductID,1,140);
        //     OrderDetails order7=new OrderDetails(booking2.BookingID,product9.ProductID,1,20);
        //     OrderDetails order8=new OrderDetails(booking3.BookingID,product2.ProductID,2,100);
        //     OrderDetails order9=new OrderDetails(booking3.BookingID,product8.ProductID,4,100);
        //     OrderDetails order10=new OrderDetails(booking3.BookingID,product1.ProductID,2,80);
        //     orderList.AddRange(new CustomList<OrderDetails> {order1,order2,order3,order4,order5,order6,order7,order8,order9,order10});

        // }
    }
}