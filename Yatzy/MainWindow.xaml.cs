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

namespace Yatzy 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRollDices_Click(object sender, RoutedEventArgs e)
        {
            int dieOne, dieTwo, dieThree, dieFour, dieFive, totalSum, bonus;
            // uppdrag
            // kasta en tärning och presentera resultatet


            dieOne = random.Next(1, 7);
            dieTwo = random.Next(1, 7);
            dieThree = random.Next(1, 7);
            dieFour = random.Next(1, 7);
            dieFive = random.Next(1, 7);

            lbldieOne.Content = dieOne;
            lbldieTwo.Content = dieTwo;
            lbldieThree.Content = dieThree;
            lbldieFour.Content = dieFour;
            lbldieFive.Content = dieFive;

            totalSum = dieOne + dieTwo + dieThree + dieFour + dieFive;

            if (totalSum >= 63)
            {
                bonus = 50;
                totalSum += bonus;

            }
            else
            {
                bonus = 0;
            }
            txtBonus.Text = bonus.ToString();
            // Alt piltangent för att flytta rad
            txtTotal.Text = totalSum.ToString();
        }
    }
}
