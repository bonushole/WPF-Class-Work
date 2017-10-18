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
    /// Interaction logic for DepositWindow.xaml
    /// </summary>
    public partial class DepositWindow : Window
    {
        Account account;
        
        public DepositWindow(Account account)
        {
            this.account = account;

            
            InitializeComponent();
        }
        
        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            account.balance+=double.Parse(depositBox.Text);
            this.Close();
            
        }
        private void returnButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
