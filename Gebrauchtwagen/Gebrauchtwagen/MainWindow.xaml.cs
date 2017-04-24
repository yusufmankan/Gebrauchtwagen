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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private MySqlConnection conn;
        private List<Fahrzeug> fahrzeuge;
        public MainWindow()
        {
            InitializeComponent();          
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var connstring = ConfigurationManager.AppSettings["connstring"];
            conn = new MySqlConnection(connstring);
            Anzeigen();
        }

        private void Anzeigen()
        {
            try
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT Fid, Marke, Model, Preis, Kilometerstand, Baujahr, Treibstoff, Getriebeart, Leistung, Beschreibung FROM fahrzeug", conn);
                fahrzeuge = new List<Fahrzeug>();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        var fahrzeuges = new Fahrzeug();
                        if (rdr.IsDBNull(0))
                            throw new Exception("Primary Key is Null");
                        fahrzeuges.fid = Convert.ToInt32(rdr.GetString(0));
                        fahrzeuges.marke = rdr.IsDBNull(1) ? "keine Daten" : rdr.GetString(1);
                        fahrzeuges.model = rdr.IsDBNull(2) ? "keine Daten" : rdr.GetString(2);
                        fahrzeuges.preis = Convert.ToInt32(rdr.IsDBNull(3) ? "keine Daten" : rdr.GetString(3));
                        fahrzeuges.kilometerstand = Convert.ToInt32(rdr.IsDBNull(4) ? "keine Daten" : rdr.GetString(4));
                        fahrzeuges.baujahr = Convert.ToInt32(rdr.IsDBNull(5) ? "keine Daten" : rdr.GetString(5));
                        fahrzeuges.treibstoff = rdr.IsDBNull(6) ? "keine Daten" : rdr.GetString(6);
                        fahrzeuges.getriebeart = rdr.IsDBNull(7) ? "keine Daten" : rdr.GetString(7);
                        fahrzeuges.leistung = Convert.ToInt32(rdr.IsDBNull(8) ? "keine Daten" : rdr.GetString(8));
                        fahrzeuges.beschreibung = rdr.IsDBNull(9) ? "keine Daten" : rdr.GetString(9);
                        WriteLine(fahrzeuges.ToString());
                        fahrzeuge.Add(fahrzeuges);

                    }
                }
                dataGrid.ItemsSource = fahrzeuge;
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_hochladen_Click(object sender, RoutedEventArgs e)
        {
            
        }

      

    

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void auto_hochladen(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }

        private void radioButton_BMW_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioButton_BMW.IsChecked == true)
                {
                    conn.Open();
                    fahrzeuge = new List<Fahrzeug>();
                    var cmd = new MySqlCommand("SELECT Fid, Marke, Model, Preis, Kilometerstand, Baujahr, Treibstoff, Getriebeart, Leistung, Beschreibung FROM fahrzeug WHERE Marke = '" + "BMW" + "'", conn);

                    using (var rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            var bmw = new Fahrzeug();
                            bmw.fid = Convert.ToInt32(rdr.GetString(0));
                            bmw.marke = rdr.GetString(1);
                            bmw.model = rdr.GetString(2);
                            bmw.preis = Convert.ToInt32(rdr.GetString(3));
                            bmw.kilometerstand = Convert.ToInt32(rdr.GetString(4));
                            bmw.baujahr = Convert.ToInt32(rdr.GetString(5));
                            bmw.treibstoff = rdr.GetString(6);
                            bmw.getriebeart = rdr.GetString(7);
                            bmw.leistung = Convert.ToInt32(rdr.GetString(8));
                            bmw.beschreibung = rdr.GetString(9);
                            fahrzeuge.Add(bmw);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGrid.ItemsSource = fahrzeuge;
            conn.Close();
        }

        private void radioButton_VW_Checked(object sender, RoutedEventArgs e)
        {

            try
            {
                if (radioButton_VW.IsChecked == true)
                {
                    conn.Open();
                    fahrzeuge = new List<Fahrzeug>();
                    var cmd = new MySqlCommand("SELECT Fid, Marke, Model, Preis, Kilometerstand, Baujahr, Treibstoff, Getriebeart, Leistung, Beschreibung FROM fahrzeug WHERE Marke = '" + "VW" + "'", conn);

                    using (var rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            var vw = new Fahrzeug();
                            vw.fid = Convert.ToInt32(rdr.GetString(0));
                            vw.marke = rdr.GetString(1);
                            vw.model = rdr.GetString(2);
                            vw.preis = Convert.ToInt32(rdr.GetString(3));
                            vw.kilometerstand = Convert.ToInt32(rdr.GetString(4));
                            vw.baujahr = Convert.ToInt32(rdr.GetString(5));
                            vw.treibstoff = rdr.GetString(6);
                            vw.getriebeart = rdr.GetString(7);
                            vw.leistung = Convert.ToInt32(rdr.GetString(8));
                            vw.beschreibung = rdr.GetString(9);
                            fahrzeuge.Add(vw);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGrid.ItemsSource = fahrzeuge;
            conn.Close();
        }

        private void radioButton_Mercedes_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                if (radioButton_Mercedes.IsChecked == true)
                {
                    conn.Open();
                    fahrzeuge = new List<Fahrzeug>();
                    var cmd = new MySqlCommand("SELECT Fid, Marke, Model, Preis, Kilometerstand, Baujahr, Treibstoff, Getriebeart, Leistung, Beschreibung FROM fahrzeug WHERE Marke = '" + "Mercedes" + "'", conn);

                    using (var rdr = cmd.ExecuteReader())
                    {

                        while (rdr.Read())
                        {
                            var mercedes = new Fahrzeug();
                            mercedes.fid = Convert.ToInt32(rdr.GetString(0));
                            mercedes.marke = rdr.GetString(1);
                            mercedes.model = rdr.GetString(2);
                            mercedes.preis = Convert.ToInt32(rdr.GetString(3));
                            mercedes.kilometerstand = Convert.ToInt32(rdr.GetString(4));
                            mercedes.baujahr = Convert.ToInt32(rdr.GetString(5));
                            mercedes.treibstoff = rdr.GetString(6);
                            mercedes.getriebeart = rdr.GetString(7);
                            mercedes.leistung = Convert.ToInt32(rdr.GetString(8));
                            mercedes.beschreibung = rdr.GetString(9);
                            fahrzeuge.Add(mercedes);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGrid.ItemsSource = fahrzeuge;
            conn.Close();
        }
    }
    }

