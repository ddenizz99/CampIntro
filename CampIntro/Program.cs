using System;
using System.Collections.Generic;
using System.Linq;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string ParaBirim(decimal para)
            {
                string s = para.ToString("#,##0");

                return s + " TL";
            }

            List<Product> products = new List<Product>();

            products.Add(new Product(1, "Araba", 180000, 2));
            products.Add(new Product(2, "Telefon", 3540, 1));
            products.Add(new Product(3, "Bilgisayar", 10000, 1));

            List<Categori> categoris = new List<Categori>();

            categoris.Add(new Categori {CategoriId = 1, CategoriName = "Elektronik"});
            categoris.Add(new Categori { CategoriId = 2, CategoriName = "Otomobil" });



            Console.WriteLine("Ürünler listesinde {0} adet ürün var ;" , products.Count);

            foreach (Product product in GetProductList(products))
            {
                Console.WriteLine("{0} ID li ürünün adı {1}, fiyatı {2} dir.",  product.Id, product.Name, ParaBirim(product.Price));
            }

            List<Product> GetProductList(List<Product> products)
            {
                return products.Where(p => p.Price > 3540).ToList();
            }

        }
    }

    class Categori
    {
        public int CategoriId { get; set; }

        public string CategoriName { get; set; }
    }
}
