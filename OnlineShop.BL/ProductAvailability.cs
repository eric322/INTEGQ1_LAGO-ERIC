using OnlineShop.DL;
using System;
using System.Collections.Generic;
namespace OnlineShop.BL

{
    public class ProductAvailability
    {
        public List<ProductName> ProductInfo = new List<ProductName>()
        {
            new ProductName ("Adidas YEEZY BOOST 350","$499", new DateTime(2021,6,26)),
        };

        public void ProductView()
        {
            foreach (ProductName product in ProductInfo)
            {
                Console.WriteLine("SHOES DESIGN:{0}|Price: {1}|Date: {2}", product.ShoesDesign, product.Price, product.Date);
            }
        }
        public void ProductAdd()
        {
            foreach (ProductName product in ProductInfo)
            {
                Console.WriteLine("SHOES DESIGN:{0}|Price:$ {1}| Date Time:{2}", product.ShoesDesign, product.Price, product.Date);
            }

            Console.WriteLine("Enter SHOES DESIGN: ");
            string addProduct = Console.ReadLine();
            Console.WriteLine("Enter Price:$ ");
            string addPrice = Console.ReadLine();
            DateTime addDate = DateTime.Now;


            ProductInfo.Add(new ProductName(addProduct, addPrice, addDate));
            Console.WriteLine("SHOES DESIGN:{0} | Price:${1} |Date: {2}| Successfully Added", addProduct, addPrice, addDate);

            foreach (ProductName product in ProductInfo)
            {
                Console.WriteLine("SHOES DESIGN:{0}|Price:$ {1}| Date:{2}", product.ShoesDesign, product.Price, product.Date);
            }
        }
        public void ProductRemoved()
        {
            Console.WriteLine("Enter Index Position:");
            int indexPosition = int.Parse(Console.ReadLine());

            ProductInfo.RemoveAt(indexPosition);

            foreach (ProductName product in ProductInfo)
            {
                Console.WriteLine("SHOES DESIGN:{0}|Price:$ {1}| Date:{2}", product.ShoesDesign, product.Price, product.Date);
            }
        }
    }
}