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
    /// Interaction logic for CreditsPage.xaml
    /// </summary>
    public partial class CreditsPage : Page
    {
        public CreditsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Knoppen credits pagina. Terug naar hoofdmenu en afsluiten applicatie.
        /// </summary>

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }


    }
}
