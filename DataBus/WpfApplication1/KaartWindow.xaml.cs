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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for KaartWindow.xaml
    /// </summary>
    public partial class KaartWindow : Window
    {
        public KaartWindow()
        {
            InitializeComponent();
            Main.Content = new KaartPage();
        }

        /// <summary>
        /// Knoppen voor navigatie.
        /// </summary>

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        /// <summary>
        /// KILL ME.
        /// </summary>

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}