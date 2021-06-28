using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DL
{
   public class AccountName
    {
        private string username;
        private string password;
        public AccountName(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
    }
}