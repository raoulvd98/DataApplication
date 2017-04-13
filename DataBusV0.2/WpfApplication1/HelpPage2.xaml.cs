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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for HelpPage2.xaml
    /// </summary>
    public partial class HelpPage2 : Window
    {
        HelpPage help;
        HelpPage2 help2;
        HelpPage3 help3;

        public HelpPage2()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            help3 = new WpfApplication1.HelpPage3();
            help3.Show();
            Close();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            help = new WpfApplication1.HelpPage();
            help.Show();
            Close();
        }
    }
}
