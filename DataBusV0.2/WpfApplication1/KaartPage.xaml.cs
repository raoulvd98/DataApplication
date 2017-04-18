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
    /// Interaction logic for KaartPage.xaml
    /// </summary>
    public partial class KaartPage : Page
    {

        public KaartPage()
        {
            InitializeComponent();
        }

        private void CharloisBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Charlois");
        }
        private void DelfshavenBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Delfshaven");
        }
        private void FeijenoordBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Feijenoord");
        }
        private void HillegersbergBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Hillegersberg-Schiebroek");
        }
        private void HoekvHollandBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Hoek van Holland");
        }
        private void HoogvlietBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Hoogvliet/Pernis");
        }
        private void IJsselmondeBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Ijsselmonde");
        }
        private void KralingenBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Kralingen-Crooswijk");
        }
        private void NoordBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Noord");
        }
        private void OverschieBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Overschie");
        }
        private void PrinsAlexanderBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Prins Alexander");
        }
        private void CentrumBut(object sender, RoutedEventArgs e)
        {
            PINO.Content = new DataKaart("Stadscentrum");
        }
        private void WaalhavenBut(object sender, RoutedEventArgs e)
        {
           
        }

    }
}
