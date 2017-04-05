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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            showChart();
        }

        private void showChart()
        {
            string ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=Hallo";

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ov", connection);


                
                connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
                string wijk = reader.GetString(0);
                int mensen_met_auto = reader.GetInt32(1);

            Console.WriteLine(mensen_met_auto);
            







            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();
            MyValue.Add(new KeyValuePair<string, int>("MENSEN MET AUTO", mensen_met_auto));
            MyValue.Add(new KeyValuePair<string, int>("Management", 36));
            MyValue.Add(new KeyValuePair<string, int>("Development", 89));
            MyValue.Add(new KeyValuePair<string, int>("Support", 270));
            MyValue.Add(new KeyValuePair<string, int>("Sales", 140));
            LineChart1.DataContext = MyValue;

        }

    }
}
