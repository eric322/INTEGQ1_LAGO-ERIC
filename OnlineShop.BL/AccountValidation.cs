using OnlineShop.DL;
using System;
using System.Collections.Generic;

namespace OnlineShop.BL
{
    public class AccountValidation
    {
        public List<AccountName> UserCredentials = new List<AccountName>()
        {
            new AccountName("Eric","1234")
        };

        public void LogIn()
        {
            AccountCatalogue catalogue = new AccountCatalogue();
            bool successful = false;
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string passWord = Console.ReadLine();

            foreach (AccountName user in UserCredentials)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Log in Success");
                    successful = true;
                    catalogue.Catalogue();
                }
            }
            if (!successful)
            {
                Console.WriteLine("Wrong Information!!!");
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string passWord = Console.ReadLine();

            UserCredentials.Add(new AccountName(userName, passWord));
            Console.WriteLine("Registered Successfully!");

            foreach (AccountName user in UserCredentials)
            {
                Console.WriteLine("Username:{0}, Passw:{1}", user.UserName, user.PassWord);
            }

        }
    }
}