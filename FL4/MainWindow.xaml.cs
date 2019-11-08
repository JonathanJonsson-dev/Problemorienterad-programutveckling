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

namespace FL4
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

        private void BtnCalculateBmi_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(txtHeight.Text), mass = double.Parse(txtMass.Text);
            double bmi;
            bmi = mass / (height * height);
            txtResult.Text = Math.Round(bmi, 2).ToString();

            bmi = 24.5;
            int value = (int)bmi; // cast, låssas att det är en integer 

            if (bmi < 18.5)
            {

            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                // normal
            }
            else
            {
                // Övervikt
            }
        }
    }
}
