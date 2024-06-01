using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        protected string full_name;
        protected string user_name;
        protected string user_password;


        public UserAccount(string name, string uname, string password)
        {
            this.full_name = name;
            this.user_name = uname;
            this.user_password = password;
        }

        public abstract bool validateLogin(string uname, string password);
    }
}
