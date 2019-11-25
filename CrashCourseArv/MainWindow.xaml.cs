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

namespace CrashCourseArv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Vegetable vegetable;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Vegetable> vegetables = new List<Vegetable>();
            vegetable = new Cucumber()
            {
                Price = 15.6M,
            };

            vegetables.Add(vegetable);

            vegetable = new Broccoli()
            {
                Price = 15.6M,
            };

            vegetables.Add(vegetable);

            vegetable = new Cucumber()
            {
                Price = 15.6M,
            };

            vegetables.Add(vegetable);

            //vegetable.Chop(vegetable);

            foreach  (Vegetable veggie in vegetables)
            {
                MessageBox.Show(veggie.Chop());
               
            }

            // Skapa kund
            // skapa konto
            // ge kunden detta konto
            // sätt in ett belopp
            // ta ut ett annat belopp


        }
    }
}
