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

namespace CircleCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double pi = Math.PI;
        double radius;
        double area;
        double circumference;


        public MainWindow()
        {
            InitializeComponent();
           
        }


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender == rBox) {

                radius = Double.Parse(rBox.Text);
                area = pi*radius*radius;
                circumference = 2 * pi * radius;

            }
            if (sender == cBox) {

                circumference = Double.Parse(cBox.Text);

            }
            update();

        }
        private void update() {

            rBox.Text = radius.ToString();
            cBox.Text = circumference.ToString();
            aBox.Text = area.ToString();
            slider.Value = radius;

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            radius = slider.Value;
            update();
        }
    }
}
