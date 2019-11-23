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
        GameEngine gameEngine;


        public MainWindow()
        {
            // Den här koden körs endas en gång
            InitializeComponent();
            gameEngine = new GameEngine();
        }

        private void btnRollDices_Click(object sender, RoutedEventArgs e)
        {

            




            // skapa ett objekt/instans av GameEngine 
            GameEngine gameEngine = new GameEngine();
            int score = 13;
            int category = 3;

            bool result = gameEngine.IsValidScore(score, category);
            int dieOne, dieTwo, dieThree, dieFour, dieFive;
            dieOne = gameEngine.RoleDie();

            int bonus;
            // uppdrag
            // kasta en tärning och presentera resultatet

            /*
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
            */

            //Refaktorera
            // 5 separata tärningar? Nej, 
            int totalSum = 0;

            int[] dices = new int[5];
            for (int i = 0; i < 5; i++)
            {
                dices[i] = gameEngine.RoleDie();
            }

            foreach (int die in dices)
            {
                totalSum += die;
            }

            //totalSum = dieOne + dieTwo + dieThree + dieFour + dieFive;

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

            lbldieOne.Content = dices[0];
            lbldieTwo.Content = dices[1];

        }

        private void BtnSaveScore_Click(object sender, RoutedEventArgs e)
        {
            
            int score = 13;
            //bool result = gameEngine.IsValidScore(score, 3);
            bool result = gameEngine.SaveScore(score, 3);

            gameEngine.Ones = 11;
            score = gameEngine.Ones;
            
            //SaveScore saveScore = new SaveScore();
            //result = SaveScore(score, 3);

        }
    }
}
