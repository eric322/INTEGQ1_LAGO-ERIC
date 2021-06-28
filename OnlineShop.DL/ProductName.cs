using System;

namespace OnlineShop.DL
{
    public class ProductName
    {
        public string shoesDesign;
        private string price;
        private DateTime date;

        public ProductName(string shoesDesign, string price, DateTime date)
        {
            this.shoesDesign = shoesDesign;
            this.price = price;
            this.date = date;


        }


        public string ShoesDesign
        {
            get { return shoesDesign; }
            set { shoesDesign = value; }
        }


        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


    }
}