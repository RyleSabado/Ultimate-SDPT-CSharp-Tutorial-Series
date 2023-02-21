using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_SDPT_CSharp_Tutorial_Series
{
    //Episode 19 
    internal class OverloadingContructors
    {
        public static void OverloadingContructorsLesson()
        {
            Product p = new Product(111, "Bingo", "Choco Cookies", 100, 45.45f);
            Product p1 = new Product(112, "Nissin Wafer", 15, 12.2f);
        }
    }
    class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int productStock { get; set; }
        public float productPrice { get; set;}

        public Product(int productID, string productName, string productDescription, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productDescription = productDescription;
            this.productStock = productStock;
            this.productPrice = productPrice;

            Console.WriteLine("Product ID           :" + productID);
            Console.WriteLine("Product Name         :" + productName);
            Console.WriteLine("Product Description  :" + productDescription);
            Console.WriteLine("Product Stock        :" + productStock);
            Console.WriteLine("Product Price        :" + productPrice);
        }

        public Product(int productID, string productName, int productStock, float productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productStock = productStock;
            this.productPrice = productPrice;

            Console.WriteLine("Product ID           :" + productID);
            Console.WriteLine("Product Name         :" + productName);
            Console.WriteLine("Product Stock        :" + productStock);
            Console.WriteLine("Product Price        :" + productPrice);
        }
    }
}
