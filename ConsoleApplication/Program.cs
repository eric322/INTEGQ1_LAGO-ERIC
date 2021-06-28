using OnlineShop.BL;
using System;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountValidation user = new AccountValidation();

            Console.WriteLine("ADIDAS ONLINE SHOP");
            Console.WriteLine("(1)LOG IN ");
            Console.WriteLine("(2)Register");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
            }
            else if (userInput.Equals(2))
            {
                user.Register();
            }
            else
            {

            }



        }

    }
}
