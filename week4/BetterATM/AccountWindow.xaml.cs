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

        public AccountWindow(Account account)
        {

            this.account = account;

            InitializeComponent();
        }

        public void openWindow(Window window)
        {

            window.Closed += Window_Closed;

            this.Hide();
            window.Show();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void windowButton_Click(object sender, RoutedEventArgs e, Type t)
        {
            openWindow(new typeof(t)());
        }
    }
}
