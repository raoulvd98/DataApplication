﻿using System;
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


        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
        private void CharloisBut(object sender, RoutedEventArgs e)
        {

        }
        private void DelfshavenBut(object sender, RoutedEventArgs e)
        {

        }
        private void FeijenoordBut(object sender, RoutedEventArgs e)
        {

        }
        private void HillegersbergBut(object sender, RoutedEventArgs e)
        {

        }
        private void HoekvHollandBut(object sender, RoutedEventArgs e)
        {

        }
        private void HoogvlietBut(object sender, RoutedEventArgs e)
        {

        }
        private void IJselmondeBut(object sender, RoutedEventArgs e)
        {

        }
        private void KralingenBut(object sender, RoutedEventArgs e)
        {

        }
        private void NoordBut(object sender, RoutedEventArgs e)
        {

        }
        private void OverschieBut(object sender, RoutedEventArgs e)
        {

        }
        private void PrinsAlexanderBut(object sender, RoutedEventArgs e)
        {

        }
        private void CentrumBut(object sender, RoutedEventArgs e)
        {

        }
        private void WaalhavenBut(object sender, RoutedEventArgs e)
        {

        }

    }
}
