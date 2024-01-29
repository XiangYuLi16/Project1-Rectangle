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

namespace Project1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)    //Most of my research are based on chatgpt
        {
            if (int.TryParse(numberTextBox.Text, out int result))
            {
                myRec.Height = result + 100;    //The +100 behind sets a default height of 100 for the rectangle
            }

            if (int.TryParse(numberTextBox.Text, out int value)) // Set a limit for the height
            {
                int maxValue = 250;    //This sets the height limit to 250 which is within the window size
                numberTextBox.Text = Math.Min(value, maxValue).ToString();
            }
            else
            {
                // Handle non-numeric input
                numberTextBox.Text = "0";
            }
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        //Area
        private void numberArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(numberArea.Text, out int result))
            {
                myRec.Height = result + 100;    //The +100 behind sets a default height of 100 for the rectangle
                myRec.Width = result + 100;    //The +100 behind sets a default width of 100 for the rectangle
            }

            if (int.TryParse(numberArea.Text, out int value)) // Set a limit for the Area
            {
                int maxValue = 250;    //This sets the height limit to 250 which is within the window size
                numberArea.Text = Math.Min(value, maxValue).ToString();
            }
            else
            {
                // Handle non-numeric input
                numberArea.Text = "0";
            }
        }

        private void numberArea_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }
    }
}
