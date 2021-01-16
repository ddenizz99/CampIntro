using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention - adlandırma kuralları
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("{0} Sepete Eklendi.",product.Name);
        }
    }
}
