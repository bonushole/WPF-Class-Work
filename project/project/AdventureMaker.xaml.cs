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
        ObservableCollection<String> pointTypes = new ObservableCollection<string> { "passive", "regular" };//, "bad ending"};
        GameFile gameFile;
        string tempText;
        int tempChoiceCount;
        List<Plotpoint> tempPointList;

        Button selectedButton;

        Action<GameFile> saveGame;

        public AdventureMaker(Action<GameFile> saveGame)
        {
            InitializeComponent();
            pointTypeBox.ItemsSource = pointTypes;
            pointTypeBox.SelectedItem = pointTypes[1];
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
            editTextButton.Click += editText;

            WrapPanel choicesPanel = new WrapPanel();
            pointPanel.Children.Add(choicesPanel);

            Button selectPointButton = new Button();
            selectPointButton.Content = "  ";
            selectPointButton.IsEnabled = false;
            selectPointButton.Click += SelectPointButton_Click;
            pointPanel.Children.Add(selectPointButton);


            switch (selected)
            {

                case "passive":
                    tempChoiceCount = 1;
                    pointLabel.Content = gameFile.addPlotpoint(new Passive(tempText, tempChoiceCount, editTextButton));
                    break;

                case "bad ending":

                    pointLabel.Content = gameFile.addPlotpoint(new BadEnding());
                    break;
                case "regular":
                    tempChoiceCount = choicesBox.SelectedIndex +1;//int.Parse(choicesBox.SelectedItem.ToString());
                    pointLabel.Content = gameFile.addPlotpoint(new Regular(tempText, tempChoiceCount, editTextButton));
                    break;

                default:
                    break;
            }

            for (int i=0; i<tempChoiceCount; i++)
            {
                Button btn = new Button();
                btn.Content = "  ";
                btn.Click +=addChildPointButton_Click;
                choicesPanel.Children.Add(btn);
            }
            
        }

        private void SelectPointButton_Click(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            int index = pointsPanel.Children.IndexOf(senderButton.Parent as UIElement);

            WrapPanel selectedPanel = selectedButton.Parent as WrapPanel;
            gameFile.getPoint(pointsPanel.Children.IndexOf(selectedPanel.Parent as UIElement)).childPointList[selectedPanel.Children.IndexOf(selectedButton)]= (gameFile.getPoint(pointsPanel.Children.IndexOf(senderButton.Parent as UIElement)));
            selectedButton.Content = pointsPanel.Children.IndexOf(senderButton.Parent as UIElement)+1;

            //tempPointList = new List<Plotpoint>{ (gameFile.getPoint(pointsPanel.Children.IndexOf(senderButton.Parent as UIElement)))};

            foreach (WrapPanel panel in pointsPanel.Children)
            {
                panel.Children[3].IsEnabled = false;
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

        private void editText(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            Plotpoint senderPoint = gameFile.getPoint(pointsPanel.Children.IndexOf(senderButton.Parent as UIElement));
            TextEditWindow textWindow = new TextEditWindow(senderPoint.setText);
            textWindow.setText(senderPoint.getText());
            textWindow.Show();
        }

        private void addChildPointButton_Click(object sender, RoutedEventArgs e)
        {
            selectedButton = sender as Button;
            foreach (WrapPanel panel in pointsPanel.Children)
            {
                panel.Children[3].IsEnabled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            saveGame(gameFile);

            this.Close();
        }
    }
}
