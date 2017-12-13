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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameFile savedGame;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window makerWindow = new AdventureMaker(saveGame);

            makerWindow.Closed += openWindow;

            makerWindow.Show();
            this.Hide();
        }
        private void saveGame(GameFile game)
        {
            savedGame = game;
        }
        private void openWindow(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window playerWindow = new AdventurePlayer(savedGame);

            playerWindow.Closed += openWindow;
            playerWindow.Show();
            this.Hide();
        }
    }
}
