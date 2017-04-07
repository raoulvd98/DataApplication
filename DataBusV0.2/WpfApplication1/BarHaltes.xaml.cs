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
    public partial class BarHaltes : Page
    {
        public BarHaltes()

        {
            InitializeComponent();
            showChart();





        }

        private void showChart()
        {

            string ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=Hallo";

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM haltes", connection);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> MyValue2 = new List<KeyValuePair<string, int>>();
            while (reader.Read())
            {


                string Wijk = reader.GetString(0);
                int haltes_count = reader.GetInt32(5);
                int Totaal_OV_gebruik = reader.GetInt32(6);


                MyValue.Add(new KeyValuePair<string, int>(Wijk, haltes_count));
                MyValue2.Add(new KeyValuePair<string, int>(Wijk, Totaal_OV_gebruik));

            }
            OV.DataContext = MyValue;
            Haltes.DataContext = MyValue2;


        }

    }
}
