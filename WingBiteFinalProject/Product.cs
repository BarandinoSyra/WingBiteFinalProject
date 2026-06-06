using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingBiteFinalProject
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public int Stock { get; set; }


        public decimal Price { get; set; }

        public int ProductsSold { get; set; }
    }

    public static class ProductData
    {
        public static List<Product> products =
            new List<Product>()
            {
                new Product
                {
                    ProductID = 1001,
                    ProductName = "Classic Wings",
                    Category = "Wings",
                    Price = 120,
                    ProductsSold = 25
                },

                new Product
                {
                    ProductID = 1002,
                    ProductName = "Buffalo Wings",
                    Category = "Wings",
                    Price = 135,
                    ProductsSold = 18
                },

                new Product
                {
                    ProductID = 1003,
                    ProductName = "Garlic Parmesan Wings",
                    Category = "Wings",
                    Price = 140,
                    ProductsSold = 14
                },

                new Product
                {
                    ProductID = 2001,
                    ProductName = "Chicken Rice Meal",
                    Category = "Rice Platter",
                    Price = 99,
                    ProductsSold = 30
                },

                new Product
                {
                    ProductID = 2002,
                    ProductName = "Pork BBQ Rice",
                    Category = "Rice Platter",
                    Price = 110,
                    ProductsSold = 20
                },

                new Product
                {
                    ProductID = 2003,
                    ProductName = "Sisig Rice",
                    Category = "Rice Platter",
                    Price = 125,
                    ProductsSold = 11
                },

                new Product
                {
                    ProductID = 3001,
                    ProductName = "Coke",
                    Category = "Drinks",
                    Price = 35,
                    ProductsSold = 40
                },

                new Product
                {
                    ProductID = 3002,
                    ProductName = "Royal",
                    Category = "Drinks",
                    Price = 35,
                    ProductsSold = 22
                },

                new Product
                {
                    ProductID = 3003,
                    ProductName = "Milktea",
                    Category = "Drinks",
                    Price = 85,
                    ProductsSold = 15
                }
            };
    }
}