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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        MainApp application;
        KaartWindow application1;
        HelpPage application2;

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigatie van alle knoppen uit hoofdmenu.
        /// </summary>

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            application = new WpfApplication1.MainApp();
            application.Show();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            application2 = new WpfApplication1.HelpPage();
            application2.Show();
        }

        private void CreditsButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new CreditsPage();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
             Main.Content = new EditPage();
        }

        private void KaartButton_Click(object sender, RoutedEventArgs e)
        {
            application1 = new WpfApplication1.KaartWindow();
            application1.Show();
        }
    }
}

