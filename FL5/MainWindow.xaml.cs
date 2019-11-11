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

namespace FL5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum = 0;
        // skapar en array som ett objekt, måste skriva hur stor den är tex 5, får alltid ett startvärde 0
        int[] values = new int[5];
        int index = 0;
        int[] result;

        //konstruktor
        public MainWindow() //konstruktor
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // array = samling av flera värden av samma typ 
            //[12, 23, 55, 67, 100];

            int value = int.Parse(txtValue.Text);

            values[index] = value;
            index++;

            //for kan användas till allt

            // foreach smart när vi vill titta igenom en lista eller array

            //sum += value;

            foreach (int val in values)
            {
                if (val > 0)
                {
                    MessageBox.Show(val.ToString());
                }
                
            }
            // datatyp mellanslag = värde --> variabel
            // boolskt uttryck --> sant/falskt
            //hur ska variabeln räknas upp i++
            for (int i = 0; i < values.Length; i++)
            {
                int val = values[i];
                val += 10;
                values[i] = val;
                // använd variabel i indexuppräknare
                MessageBox.Show(val.ToString());
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string[] weekdays = new string[]
            {
                "Monday", "Tuesday"
            };

            string name = "Erik";
            //MessageBox.Show(name[0].ToString());

            //foreach (char c in name)
            //{
            //    MessageBox.Show(c.ToString());
            //}
            //skapar en tom string
            string edited = "";
            char[] namearray = name.ToCharArray();
            namearray[2] = 'B';
            //Char.IsWhiteSpace;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals('r'))
                {
                    edited += 'p';
                }
                else
                {
                    edited += name[i];
                }
                MessageBox.Show(name[i].ToString());
            }


            //int numberOfTries = int.Parse(txtValue.Text);
            result = new int[34];

            Random slump = new Random(12); //12an har påverkat slumpen
            //int resultat = slump.Next(12); 

            
        }
    }
}
