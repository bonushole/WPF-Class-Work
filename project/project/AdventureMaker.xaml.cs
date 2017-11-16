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
    public partial class AdventureMaker : Window
    {
        ObservableCollection<String> pointTypes = new ObservableCollection<string> {"passive", "bad ending"};
        public AdventureMaker()
        {
            InitializeComponent();
            pointTypeBox.ItemsSource = pointTypes;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selected = pointTypeBox.SelectedItem.ToString();
            switch (selected)
            {
                case ("passive"):
                    {
                        
                    }
                case ("bad ending"):
                    {

                    }
                default:
                    {
                        this.Hide();
                    }

            }

            Button button = new Button();
            button.Content = "button";
            pointsPanel.Children.Add(button);
        }
    }
}
