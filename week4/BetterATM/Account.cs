using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterATM
{
    public class Account
    {
        public string userName;
        double balance;
        string password;

        public Account(string userName, double balance, string password) {

            this.userName = userName;
            this.balance = balance;
            this.password = password;

        }

        public bool checkPassword(string password) {

            if (this.password == password) {

                return true;

            }
            else
            {
                return false;
            }


        }
    }
}
