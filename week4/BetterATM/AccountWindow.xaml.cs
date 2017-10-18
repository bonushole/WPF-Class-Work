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
        Action<MainWindow.windowType> changeWindow;

        public AccountWindow(Account account, Action<MainWindow.windowType> changeWindow)//(MainWindow.windowType window))
        {

            this.account = account;

            this.changeWindow = changeWindow;

            InitializeComponent();
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void balanceButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.balanceWindow);
        }
        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.withdrawWindow);
        }
        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.depositWindow);
        }
        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}
