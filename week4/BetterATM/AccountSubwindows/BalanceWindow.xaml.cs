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
using System.Windows.Shapes;

namespace BetterATM
{
    /// <summary>
    /// Interaction logic for BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        Account account;
       
        public BalanceWindow(Account account)
        {
            this.account = account;


            //IsVisibleChanged += reloadBalance;

            InitializeComponent();
            balanceLabel.Content= account.balance;
        }

        private void openNextWindow(Window window)
        {


            window.Closed += Window_Closed;
            this.Hide();
            window.Show();

        }
        private void Window_Closed(object sender, EventArgs e)
        {
            this.Show();
            balanceLabel.Content = account.balance;
        }

        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            openNextWindow(new WithdrawWindow(account));
        }
        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            openNextWindow(new DepositWindow(account));
        }
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}
