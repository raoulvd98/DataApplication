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
    public partial class LineHaltes : Page
    {
        public LineHaltes()

        {
            InitializeComponent();
            showChart();





        }

        private void showChart()
        {

            string ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=Hallo";

            MySqlConnection connection = new MySqlConnection(ConnectionString);
            MySqlConnection connection2 = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM haltes", connection);

            connection.Open();
            connection2.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<KeyValuePair<string, float>> MyValue = new List<KeyValuePair<string, float>>();
            List<KeyValuePair<string, int>> MyValue2 = new List<KeyValuePair<string, int>>();


            MySqlCommand cmd2 = new MySqlCommand("SELECT sum(Totaal_Aantal_Haltes) FROM haltes", connection2);
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader.Read())
            {
                reader2.Read();
                int tot_aantal_haltes = reader2.GetInt32(0);

                string Wijk = reader.GetString(0);
                int haltes_count = reader.GetInt32(4);
                int Totaal_OV_gebruik = reader.GetInt32(5);



                float cnt = (haltes_count * 100 / tot_aantal_haltes);

                Console.WriteLine(Wijk);
                Console.WriteLine(cnt);
                Console.WriteLine(tot_aantal_haltes);


                MyValue.Add(new KeyValuePair<string, float>(Wijk, cnt));
                MyValue2.Add(new KeyValuePair<string, int>(Wijk, Totaal_OV_gebruik));
            }

            OV.DataContext = MyValue2;
            Haltes.DataContext = MyValue;


        }

    }
}