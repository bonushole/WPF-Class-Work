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

        Window currentWindow;
        AccountWindow accountWindow;
        BalanceWindow balanceWindow;
        DepositWindow depositWindow;
        WithdrawWindow withdrawWindow;

        List<Account> accounts;

        public enum windowType{
            accountWindow,
            balanceWindow,
            depositWindow,
            withdrawWindow
            }


        public MainWindow()
        {
            InitializeComponent();
            accounts = new List<Account>();

            accounts.Add(new Account("user1", 1000, "password123"));
            accounts.Add(new Account("user2", 100000, "password789"));
            accounts.Add(new Account("user3", 0, "321password"));
            accounts.Add(new Account("user4", 10000, "password456"));

            
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
                accountWindow = new AccountWindow(userAccount, changeWindow);
                balanceWindow = new BalanceWindow(userAccount, changeWindow);
                depositWindow = new DepositWindow(userAccount, changeWindow);
                withdrawWindow = new WithdrawWindow(userAccount, changeWindow);
                
                currentWindow = accountWindow;

                accountWindow.Closed += AccountWindow_Closed;
                

                this.Hide();
                accountWindow.Show();
            }
        }
        
        private void AccountWindow_Closed(object sender, EventArgs e)
        {
            if(currentWindow==accountWindow){
                this.Show();
                userNameBox.Text="";
                passwordBox.Password="";
            }
        }
        
        private void changeWindow(windowType window)
        {
            currentWindow.Hide();

            if(window==windowType.balanceWindow) currentWindow = balanceWindow;
            if(window==windowType.accountWindow) currentWindow = accountWindow;
            if(window==windowType.depositWindow) currentWindow = depositWindow;
            if(window==windowType.withdrawWindow) currentWindow = withdrawWindow;

            currentWindow.Show();
        }

    }
}
