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
    /// Interaction logic for DataKaart.xaml
    /// </summary>
    public partial class DataKaart : Page
    {
        public DataKaart(string Wijk)
        {
            InitializeComponent();
            showChart(Wijk);
            
        }

        private void showChart(string Wijk)
        {
            
            string ConnectionString = "Server=localhost;Database=project;Uid=root;Pwd=Hallo";

            MySqlConnection connection = new MySqlConnection(ConnectionString);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM project.haltes JOIN autobezit on autobezit.Wijk = haltes.Wijk JOIN ovgebruik on ovgebruik.Wijk = haltes.Wijk WHERE haltes.Wijk ='"+Wijk+"'", connection);

            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            List<KeyValuePair<string, string>> MyValue = new List<KeyValuePair<string, string>>();
            while (reader.Read())
            {


                string wijk = reader.GetString(0);
                string bushaltes = reader.GetString(1);
                string tramhaltes = reader.GetString(2);
                string metrohaltes = reader.GetString(3);
                string haltes = reader.GetString(4);
                string OVgebruik = reader.GetString(5);
                string BezitAuto = reader.GetString(7);
                string BezitGeenAuto = reader.GetString(8);
                string OVenBezitAuto = reader.GetString(10);
                string OVenBezitGeenAuto = reader.GetString(11);


                MyValue.Add(new KeyValuePair<string, string>(Wijk, haltes));
                label.Content = wijk;
                Bhaltes.Text = "Bushaltes: " + bushaltes;
                Thaltes.Text = "Tramhaltes: " + tramhaltes;
                Mhaltes.Text = "Metrohaltes: " + metrohaltes;
                Autobezit.Text = "% autobezit: " + BezitAuto;
                OVgebruikauto.Text = "% OV gebruik + auto: " + OVenBezitAuto;
                OVgebruikzauto.Text = "% OV gebruik + geen auto: " + OVenBezitGeenAuto;


            }


        }
    }
}
