using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdventureMaker.xaml
    /// </summary>
    /// 
    

    public partial class AdventureMaker : Window
    {
        ObservableCollection<String> pointTypes = new ObservableCollection<string> { "passive" };//, "bad ending"};
        GameFile gameFile;
        string tempText;
        List<Plotpoint> tempPointList;

        Action<GameFile> saveGame;

        public AdventureMaker(Action<GameFile> saveGame)
        {
            InitializeComponent();
            pointTypeBox.ItemsSource = pointTypes;
            pointTypeBox.SelectedItem = pointTypes[0];
            gameFile = new GameFile();

            this.saveGame = saveGame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selected = pointTypeBox.SelectedItem.ToString();

            WrapPanel pointPanel = new WrapPanel();
            pointsPanel.Children.Add(pointPanel);

            Label pointLabel = new Label();
            pointPanel.Children.Add(pointLabel);

            Button editTextButton = new Button();
            pointPanel.Children.Add(editTextButton);
            editTextButton.Content = "edit text";
            editTextButton.Click += editTextButton_Click;

            Button selectPointButton = new Button();
            selectPointButton.Content = "  ";
            selectPointButton.IsEnabled = false;
            selectPointButton.Click += SelectPointButton_Click;
            pointPanel.Children.Add(selectPointButton);


            switch (selected)
            {

                case "passive":

                    pointLabel.Content = gameFile.addPlotpoint(new Passive(tempText, tempPointList, editTextButton));
                    break;

                case "bad ending":

                    pointLabel.Content = gameFile.addPlotpoint(new BadEnding());
                    break;

                default:
                    break;
            }
            

            
        }

        private void SelectPointButton_Click(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            int index = pointsPanel.Children.IndexOf(senderButton.Parent as UIElement);

            tempPointList = new List<Plotpoint>{ (gameFile.getPoint(pointsPanel.Children.IndexOf(senderButton.Parent as UIElement)))};

            foreach (WrapPanel panel in pointsPanel.Children)
            {
                panel.Children[2].IsEnabled = false;
            }

        }

        public void setTempText(string text)
        {
            tempText = text;
        }

        private void editTextButton_Click(object sender, RoutedEventArgs e)
        {
            TextEditWindow textWindow = new TextEditWindow(setTempText);
            textWindow.Show();
        }

        private void addChildPointButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (WrapPanel panel in pointsPanel.Children)
            {
                panel.Children[2].IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            this.Close();
        }
    }
}
