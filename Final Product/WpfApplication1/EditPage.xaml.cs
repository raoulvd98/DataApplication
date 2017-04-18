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
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        public EditPage()
        {
            InitializeComponent();
            BindComboBox(comboBox);
        }

        /// <summary>
        /// Connectie met database. Database openen, uitlezen, weergeven en selecteren.
        /// </summary>

        public void BindComboBox(ComboBox comboBoxName)
        {
            MySqlConnection connection = new MySqlConnection(((MainWindow)System.Windows.Application.Current.MainWindow).Connection());

            MySqlCommand cmd = new MySqlCommand("SELECT Wijk FROM Haltes", connection);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxName.Items.Add(reader.GetString(0));
            }
        }

        /// <summary>
        /// Connectie met database. Database openen en aanpassen.
        /// </summary>

        private void PLUS1(object sender, RoutedEventArgs e)
        {
            string add = comboBox.SelectedValue.ToString();
            Console.WriteLine(add);

            MySqlConnection connection = new MySqlConnection(((MainWindow)System.Windows.Application.Current.MainWindow).Connection());

            MySqlCommand cmd = new MySqlCommand("UPDATE project.haltes SET Totaal_Aantal_Haltes = Totaal_Aantal_Haltes + 1 WHERE Wijk = '"+add+"'", connection);

            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        /// <summary>
        /// Connectie met database. Database openen en aanpassen.
        /// </summary>

        private void MIN1(object sender, RoutedEventArgs e)
        {
            string add = comboBox.SelectedValue.ToString();
            Console.WriteLine(add);

            MySqlConnection connection = new MySqlConnection(((MainWindow)System.Windows.Application.Current.MainWindow).Connection());

            MySqlCommand cmd = new MySqlCommand("UPDATE project.haltes SET Totaal_Aantal_Haltes = Totaal_Aantal_Haltes - 1 WHERE Wijk = '" + add + "'", connection);

            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
        }

        /// <summary>
        /// Knoppen voor terug naar hoofdmenu en afsluiten applicatie.
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
