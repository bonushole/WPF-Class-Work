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
        GameFile gameFile;
        public AdventureMaker()
        {
            InitializeComponent();
            pointTypeBox.ItemsSource = pointTypes;
            pointTypeBox.SelectedItem = pointTypes[0];
            gameFile = new GameFile();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string selected = pointTypeBox.SelectedItem.ToString();

            WrapPanel pointPanel = new WrapPanel();
            Label pointLabel = new Label();
            


            switch (selected)
            {

                case "passive":

                    gameFile.addPlotpoint(new Passive());
                    break;

                case "bad ending":

                    gameFile.addPlotpoint(new BadEnding());
                    break;

                default:
                    break;
            }


            
        }

        private void editTextButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
