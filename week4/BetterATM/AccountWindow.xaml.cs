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
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        Account account;

        public AccountWindow(Account account)//(MainWindow.windowType window))
        {

            this.account = account;

           

            InitializeComponent();
        }



        private void Window_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void openNextWindow(Window window) {


            window.Closed += Window_Closed;
            this.Hide();
            window.Show();

        }

        private void balanceButton_Click(object sender, RoutedEventArgs e)
        {
            openNextWindow(new BalanceWindow(account));
        }
        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            openNextWindow(new WithdrawWindow(account));
        }
        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            
            openNextWindow(new DepositWindow(account));
        }
        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void transferButton_Click(object sender, RoutedEventArgs e)
        {
            openNextWindow(new TransferWindow(account));
        }
    }
}
