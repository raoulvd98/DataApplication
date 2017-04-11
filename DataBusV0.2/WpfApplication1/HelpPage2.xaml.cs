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
    public partial class HelpPage2 : Page
    {
        public HelpPage2()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Help2.Content = new MainPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            Help2.Content = new HelpPage3();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Help2.Content = new HelpPage();
        }
    }
}
