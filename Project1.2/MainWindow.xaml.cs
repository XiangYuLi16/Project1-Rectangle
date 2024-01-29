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

        //Height
        private void numberHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(numberHeight.Text, out int result))
            {
                Triangle.Points = new PointCollection
                {
                    new Point(200, 200),       // Bottom-left vertex
                    new Point(250,120-result),        // Top vertex
                    new Point(300, 200)   // Bottom-right vertex
                };
            }

            if (int.TryParse(numberHeight.Text, out int value)) // Set a limit for the Area
            {
                int maxValue = 120;    // This sets the Area limit to 250 which is within the window size
                numberHeight.Text = Math.Min(value, maxValue).ToString();
            }
            else
            {
                // Handle non-numeric input
                numberHeight.Text = "0";
            }
        }
        private void numberHeight_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void numberArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(numberArea.Text, out int result))
            {
                Triangle.Points = new PointCollection
                {
                    new Point(200-result, 200),       // Bottom-left vertex
                    new Point(250,120-result),        // Top vertex
                    new Point(300+result, 200)   // Bottom-right vertex
                };
            }

            if (int.TryParse(numberArea.Text, out int value)) // Set a limit for the Area
            {
                int maxValue = 120;    // This sets the Area limit to 250 which is within the window size
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

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            // Set the Fill property of the Polygon (Triangle) to red
            Triangle.Fill = Brushes.Red;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            // Set the Fill property of the Polygon (Triangle) to red
            Triangle.Fill = Brushes.Blue;
        }


    }
}
