using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dont repeat yourself             
            Product product1 = new Product() {
                Id = 1, 
                Name = "Elma", 
                Price = 1.20, 
                Description = "Amasya Elması"
            };

            Product product2 = new Product() {
                Id = 2, 
                Name = "Karpuz", 
                Price = 3.40, 
                Description = "Diyarbakır Karpuzu"
            };

            Product product3 = new Product() {
                Id = 3, 
                Name = "Muz", 
                Price = 0.20, 
                Description = "Ajdar Muzu"
            };

            Product[] products = new Product[] {
                product1, 
                product2, 
                product3
            };

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün ID : {0}", product.Id);
                Console.WriteLine("Ürün adı : {0}", product.Name);
                Console.WriteLine("Ürün fiyatı : {0} TL", product.Price);
                Console.WriteLine("Ürün açıklaması : {0}", product.Description);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("-------------Metodlar-------------");
            //instance - örnek
            CartManager cart = new CartManager();
            cart.Add(product2);

            Console.ReadKey();
        }
    }
}
