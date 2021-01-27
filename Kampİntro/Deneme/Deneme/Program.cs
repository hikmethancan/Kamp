using System;

namespace Deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "XIAOMI";
            product1.Price = 2999;

            Product product2 = new Product();
            product2.productName = "IPHONE";
            product2.Price = 11999;

            Product product3 = new Product();
            product3.productName = "SAMSUNG";
            product3.Price = 4999;

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("for dongusu icin:");


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Urun Adi : " + products[i].productName + " ///" + " Fiyati : " + products[i].Price);


            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine(" foreach dongusu icin : ");


            foreach (var item in products)
            {
                Console.WriteLine(item.productName + " : " + item.Price);

            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("While dongusu icin :");

            int a = 0;

            while (a<products.Length)
            {
                Console.WriteLine("urun Adi : " + products[a].productName + " // "+" Fiyati" + " : " +  products[a].Price);
                a++;


            }
        }
    }
    class Product
    {
        public string productName { get; set; }

        public int Price { get; set; }
    }
}
