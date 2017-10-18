using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BetterATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        AccountWindow accountWindow;

        List<Account> accounts;

        public MainWindow()
        {
            InitializeComponent();
            accounts = new List<Account>();

            accounts.Add(new Account("user1", 1000, "password123",transferFunds));
            accounts.Add(new Account("user2", 100000, "password789", transferFunds));
            accounts.Add(new Account("user3", 0, "321password", transferFunds));
            accounts.Add(new Account("user4", 10000, "password456", transferFunds));

            
        }
        private void transferFunds(string accountName, double amount, Account sourceAccount)
        {

            foreach (Account account in accounts)
            {
                
                if (accountName == account.userName)
                {

                    sourceAccount.balance -= amount;
                    account.balance += amount;

                }


            }

        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            Account userAccount = null;

            foreach (Account account in accounts) {


                if (userNameBox.Text == account.userName)
                {

                    userAccount = account;

                }

            }

            if (userAccount!=null && userAccount.checkPassword(passwordBox.Password)) {
                accountWindow = new AccountWindow(userAccount);
                accountWindow.Closed += AccountWindow_Closed;
                

                this.Hide();
                accountWindow.Show();
            }
        }

        private void AccountWindow_Closed(object sender, EventArgs e)
        {
         
            this.Show();
            userNameBox.Text = "";
            passwordBox.Password = "";

        }

    }
}
