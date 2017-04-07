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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainApp : Window
    {

        public MainApp()
        {
            InitializeComponent();

        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            if ((checkBox.IsChecked == false) && (OVgebruik.IsChecked == true))
            {
                Main.Content = new LineOVgebruik();
            }

            else if ((checkBox.IsChecked == true) && (OVgebruik.IsChecked == true))
            {
                Main.Content = new BarOVgebruik();
            }

            if ((checkBox.IsChecked == false) && (Autobezit.IsChecked == true))
            {
                Main.Content = new LineAutobezit();
            }

            else if ((checkBox.IsChecked == true) && (Autobezit.IsChecked == true))
            {
                Main.Content = new BarAutobezit();
            }

            else if ((checkBox.IsChecked == false) && (Haltes.IsChecked == true))
            {
                Main.Content = new LineHaltes();
            }

            else if ((checkBox.IsChecked == true) && (Haltes.IsChecked == true))
            {
                Main.Content = new BarHaltes();
            }

        }
    }
}
