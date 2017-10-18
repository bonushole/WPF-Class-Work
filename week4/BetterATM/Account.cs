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
        public double balance;
        string password;
        Action<string, double, Account> transferFunds;

        public Account(string userName, double balance, string password, Action<string, double, Account> transferFunds) {

            this.userName = userName;
            this.balance = balance;
            this.password = password;
            this.transferFunds = transferFunds;

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
        public void sendMoney(string accountName, double amount){

            transferFunds(accountName, amount, this);
            
            }
        }
    }

