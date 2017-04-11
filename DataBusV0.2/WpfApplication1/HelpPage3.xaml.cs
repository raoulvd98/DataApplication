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
    /// Interaction logic for HelpPage3.xaml
    /// </summary>
    public partial class HelpPage3 : Page
    {
        public HelpPage3()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Help3.Content = new MainPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            Help3.Content = new HelpPage2();
        }
    }
}
