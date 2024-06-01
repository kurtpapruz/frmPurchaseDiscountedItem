using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uname, string password) : base(name, uname, password)
        {

        }

        public override bool validateLogin(string uname, string password)
        {
            if (uname.Equals("kurtpogi") && password.Equals("russel12345"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string getDepartment()
        {
            return department;
        }
        public string getFullname()
        {
            return full_name;
        }

    }
}
