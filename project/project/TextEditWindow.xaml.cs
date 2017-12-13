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
    /// Interaction logic for TextEditWindow.xaml
    /// </summary>
    public partial class TextEditWindow : Window
    {
        Action<string> setTempText;
        

        public TextEditWindow(Action<string> setTempText)
        {
            InitializeComponent();

            this.setTempText = setTempText;
        }

        public void setText(string text) 
        {
            plotBox.Text = text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            setTempText(plotBox.Text);
            this.Close();
        }
    }
}
