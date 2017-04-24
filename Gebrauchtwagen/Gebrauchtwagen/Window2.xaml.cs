using MySql.Data.MySqlClient;
using static System.Diagnostics.Debug;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Gebrauchtwagen
{
    /// <summary>
    /// Interaktionslogik für Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private MySqlConnection conn;
        public Window2()
        {
           
          

            InitializeComponent();

            
        }

        private void button_hochladen_Click(object sender, RoutedEventArgs e)
        {
            


            string marke = textBox_Marke.Text;
            string model = textBox_Model.Text;
            string preis = textBox_Preis.Text;
            string baujahr = textBox_Baujahr.Text;
            string km = textBox_Kilometerstand.Text;
            string getriebe = textBox_Getriebeart.Text;
            string leistung = textBox_Leistung.Text;
            string beschreibung = textBox_Beschreibung.Text;
            string treibstoff = textBox_Treibstoff.Text;
            



            string connstring = ConfigurationManager.AppSettings["connstring"];
            string cmd = ("INSERT INTO fahrzeug (Fid, Marke, Model, Preis, Kilometerstand, Baujahr, Treibstoff, Getriebeart, Leistung, Beschreibung)" + "VALUES ('" + " " + "', '" + marke + "', '" + model + "', '" + preis + "', '" + km + "', '" + baujahr + "', '" + getriebe + "', '" + leistung + "','" + beschreibung + "');");
            MySqlConnection conDataBase = new MySqlConnection(connstring);
            MySqlCommand cmdDataBase = new MySqlCommand(cmd, conDataBase);
            MySqlDataReader myReader;

            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Saved");

                while(myReader.Read())
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
