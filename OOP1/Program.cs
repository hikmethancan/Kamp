﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            // PascalCase   // CamelCase
            //case sensitive
            ProductManager productManager = new ProductManager();

            productManager.Topla2(3, 6);

            int toplamaSonucu = productManager.Topla(3, 6);

            Console.WriteLine("return yaparsan sonuc = "+toplamaSonucu * 2);

            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            

            



           


        }
    }
}
