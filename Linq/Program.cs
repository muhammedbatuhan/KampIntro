using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category> 
            { 
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };
            List<Product> products = new List<Product> 
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Lenovo Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=12200, UnitInStock=5 },
                new Product{ProductId=2, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=8500, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=15000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=7500, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=30000, UnitInStock=0}


            };

            Console.WriteLine("Algoritmik-------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 7500 && product.UnitInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq-----------------");
            var result = products.Where(product => product.UnitPrice > 7500 && product.UnitInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            } 
        }

  
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set;}
        public string CategoryName { get; set; }
    }
}
