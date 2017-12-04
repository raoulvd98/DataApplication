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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class BarOVgebruik: Page
    {
        public BarOVgebruik()
        {
            InitializeComponent();
            showChart();
        }

        /// <summary>
        /// Connectie met database. Database openen, uitlezen en weergeven.
        /// </summary>

        private void showChart()
        {
            MySqlConnection connection = new MySqlConnection(((MainWindow)System.Windows.Application.Current.MainWindow).Connection());

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ovgebruik", connection);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> MyValue2 = new List<KeyValuePair<string, int>>();
            while (reader.Read())
            {
                string Wijk = reader.GetString(0);
                int Bezit_Auto = reader.GetInt32(1);
                int Bezit_Geen_Auto = reader.GetInt32(2);

                MyValue.Add(new KeyValuePair<string, int>(Wijk, Bezit_Auto));
                MyValue2.Add(new KeyValuePair<string, int>(Wijk, Bezit_Geen_Auto));
            }
            Mensen_Met_Auto.DataContext = MyValue;
            Mensen_Zonder_Auto.DataContext = MyValue2;
        }
    }
}