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
        Action<MainWindow.windowType> changeWindow;

        public BalanceWindow(Account account, Action<MainWindow.windowType> changeWindow)
        {
            this.account = account;

            this.changeWindow = changeWindow;

            IsVisibleChanged += reloadBalance;

            InitializeComponent();
            balanceLabel.Content= account.balance;
        }

       private void reloadBalance(){
            balanceLabel.Content= account.balance;

}

         private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.withdrawWindow);
        }
        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.depositWindow);
        }
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.accountWindow);
        }
        
    }
}
