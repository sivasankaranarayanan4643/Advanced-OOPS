using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    /// <summary>
    /// ProductDetails class holds the property for the products of the instance of <see cref="ProductDetails"/> 
    /// </summary>
    public class ProductDetails
    {
        /// <summary>
        /// static field for auto incrementation of the product id of the instance of <see cref="ProductDetails"/>
        /// </summary>
        private static int s_productID=2000;
        /// <summary>
        /// Read only property which holds the product id of the instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <value></value>
        public string ProductID { get;  }
        /// <summary>
        /// Property holds the product name of the instance <see cref="ProductDetails"/>
        /// </summary>
        /// <value></value>
        public string ProductName { get; set; }
        /// <summary>
        /// Property holds the product available quantity of the instance <see cref="ProductDetails"/>
        /// </summary>
        public int QuantityAvailable { get; set; }
        /// <summary>
        /// Property holds the product price per quantity of the instance <see cref="ProductDetails"/>
        /// </summary>
        public double PricePerQuantity { get; set; }
         /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="ProductDetails"/>
        /// </summary>
        public ProductDetails(string productName,int quantityAvailable,double pricePerQuantity)
        {
            s_productID++;
            ProductID="PID"+s_productID;
            ProductName=productName;
            QuantityAvailable=quantityAvailable;
            PricePerQuantity=pricePerQuantity;
        }
         /// <summary>
        /// for initializing value for the property  in the class of the instanc eof <see cref="productDetails"/>
        /// </summary>
        public ProductDetails(string product)
        {
            string[]values=product.Split(',');
            s_productID=int.Parse(values[0].Remove(0,3));
            ProductID=values[0];
            ProductName=values[1];
            QuantityAvailable=int.Parse(values[2]);
            PricePerQuantity=double.Parse(values[3]);
        }
        /// <summary>
        /// Method for showing product details to the user of the instance of <see cref="ProductDetails"/>
        /// </summary>
        /// <param name="productList"></param>
        public static void ShowProductDetails(CustomList<ProductDetails> productList)
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine($"|{"Product ID",-10}|{"Product Name",-15}|{"Quantity Available",-10}|{"Price Per Quantity",-15}|");
            Console.WriteLine("------------------------------------------------------------------");
            foreach(ProductDetails product in productList)
            {
                Console.WriteLine($"|{product.ProductID,-10}|{product.ProductName,-15}|{product.QuantityAvailable,-18}|{product.PricePerQuantity,-18}|");
                Console.WriteLine("------------------------------------------------------------------");
            }
        }

    }
}