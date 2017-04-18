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
    /// Interaction logic for HelpPage.xaml
    /// </summary>
    public partial class HelpPage : Window
    {
        int pagestate = 1;
        public HelpPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Knoppen voor navigatie aanmaken.
        /// </summary>

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

        /// <summary>
        /// Knoppen voor navigate hulpmenu.
        /// </summary>

        private void Button_Click_Next(object sender, RoutedEventArgs e)
        {
            if (pagestate <= 3)
            {
                pagestate += 1;
            }
            write(pagestate);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            if (pagestate > 1)
            {
                pagestate -= 1;
            }
            write(pagestate);
        }

        /// <summary>
        /// Tekst van hulpmenu.
        /// </summary>

        public void write(int pagestate)
        {
            if (pagestate == 1)
            {
                info.Text = "Welkom en leuk dat je gebruik maakt van de applicatie DataBus. De applicatie is bedoeld om informatie op te doen over het OV-gebruik in Rotterdam. Er wordt met behulp van grafieken en diagrammen een vergelijking gemaakt tussen mensen met en zonder een auto en wat hiervoor het OV-gebruik is. Ook wordt gekeken of het OV-gebruik hoger of lager wordt afhankelijk van het aantal beschikbare haltes in een gemeente/wijk.";
                textBlock.Text = "Intro";
            }

            else if (pagestate == 2)
            {
                info.Text = "In het hoofdmenu kan je verschillende kanten op. Je kan hierheen, richting het helpscherm, je kan naar de “Credits” kijken en je kan de applicatie starten/afsluiten.";
                textBlock.Text = "Hoofdmenu";
            }

            else if (pagestate == 3)
            {
                info.Text = "Aan de linkerkant van het scherm zie je een aantal knoppen. Je kan hier selecteren welke tabel je wilt weergeven. Met de knop “Staafdiagram” kun je schakelen tussen een gewone grafiek en een staafdiagram. Als je een tabel hebt geselecteerd om weer te geven druk je op Filter. De grafiek/staafdiagram zal dan worden weergegeven. Met de knop Hoofdmenu ga je terug naar het hoofdmenu.";
                textBlock.Text = "Start";
            }
        }
    }
}
