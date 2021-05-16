using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  //ürünle ilgili operasyonlar. ekleme çıkarma vs.
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi." );
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
