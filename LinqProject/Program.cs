using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1 , CategoryName="Bilgisayar"},
                new Category{CategoryId=2 , CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId=1 ,CatergoryId=1 , QuabntityPerUnit="A",UnitPrice=1000,ProductName="Laptop"},
                new Product {ProductId=2 ,CatergoryId=1 , QuabntityPerUnit="A",UnitPrice=1000,ProductName="Laptop"},
                new Product {ProductId=3 ,CatergoryId=1 , QuabntityPerUnit="A",UnitPrice=1000,ProductName="Laptop"},
                new Product {ProductId=4 ,CatergoryId=2 , QuabntityPerUnit="A",UnitPrice=1000,ProductName="Telefon"},

            };


            Console.WriteLine("Algoritmik-------------");
            foreach (var product in products)
            {
                if (product.UnitPrice >500)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq-------------");

            var result = products.SingleOrDefault(product => product.UnitPrice > 500);

            foreach (var product in result )
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
