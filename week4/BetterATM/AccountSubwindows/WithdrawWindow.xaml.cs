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
    /// Interaction logic for WithdrawWindow.xaml
    /// </summary>
    public partial class WithdrawWindow : Window
    {
        Account account;
        Action<MainWindow.windowType> changeWindow;

        public WithdrawWindow(Account account, Action<MainWindow.windowType> changeWindow)
        {
            this.account = account;

            this.changeWindow = changeWindow;

            InitializeComponent();
        }
        
        

        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            account.balance-=double.Parse(depositBox.Text);
            changeWindow(MainWindow.windowType.accountWindow);
        }
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            changeWindow(MainWindow.windowType.accountWindow);
        }
    }
}
