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
    /// Interaction logic for TransferWindow.xaml
    /// </summary>
    public partial class TransferWindow : Window
    {
        Account account;
        public TransferWindow(Account account)
        {
            this.account = account;

            InitializeComponent();
        }

        private void transferButton_Click(object sender, RoutedEventArgs e)
        {
            account.sendMoney(accountNameBox.Text, double.Parse(amountBox.Text));
            this.Close();
        }

        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
