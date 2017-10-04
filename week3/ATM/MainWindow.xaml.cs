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

namespace ATM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double balance;
        double dummyValue;
        Grid currentScreen;
        public MainWindow()
        {
            InitializeComponent();
            mainMenu.Visibility = Visibility.Collapsed;
            withdrawScreeen.Visibility = Visibility.Collapsed;
            depositScreen.Visibility = Visibility.Collapsed;

            balanceLabel.Content = "$" + balance;
            currentScreen = WelcomePage;
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            bringToFront(mainMenu);
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            bringToFront(WelcomePage);
        }


        private void withdrawalButton_Click(object sender, RoutedEventArgs e)
        {
            bringToFront(withdrawScreeen);
        }

        private void depositScreenButton_Click(object sender, RoutedEventArgs e)
        {
            bringToFront(depositScreen);
        }

        private void bringToFront(Grid screen) {

            currentScreen.Visibility = Visibility.Collapsed;
            currentScreen = screen;
            screen.Visibility = Visibility.Visible;
            balanceLabel.Content = "$" + balance;


        }

        private void withdrawButton_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(withdrawBox.Text, out dummyValue)) { 
            balance -= Double.Parse(withdrawBox.Text);
        }
            bringToFront(mainMenu);
        }

        private void depositButton_Click(object sender, RoutedEventArgs e)
        {
            if (Double.TryParse(depositBox.Text, out dummyValue))
            {
                balance += Double.Parse(depositBox.Text);
            }
            bringToFront(mainMenu);
        }

    }
}
