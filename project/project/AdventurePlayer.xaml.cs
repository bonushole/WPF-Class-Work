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

namespace project
{
    /// <summary>
    /// Interaction logic for AdventurePlayer.xaml
    /// </summary>
    public partial class AdventurePlayer : Window
    {
        GameFile gameFile;
        Plotpoint currentPoint;

        public AdventurePlayer(GameFile gameFile)
        {
            this.gameFile = gameFile;

            InitializeComponent();


            updateWindow(gameFile.getPoint(0));
        }
        public void updateWindow(Plotpoint plotPoint)
        {
            currentPoint = plotPoint;
            textPanel.Content = currentPoint.getText();

            foreach (Button button in choicesPanel.Children)
            {
                button.Visibility = Visibility.Collapsed;
                button.IsEnabled = false;
            }

            for (int i=0; i<currentPoint.countChoices(); i++)
            {
                (choicesPanel.Children[i] as Button).Visibility = Visibility.Visible;
                (choicesPanel.Children[i] as Button).IsEnabled = true;
            }
        }

        private void choiceButton_Click(object sender, RoutedEventArgs e)
        {
            if(currentPoint is AdvanceablePoint)
            updateWindow(((AdvanceablePoint)currentPoint).nextPoint(0));
        }
    }
}
