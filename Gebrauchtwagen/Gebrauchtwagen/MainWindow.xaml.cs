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

namespace Gebrauchtwagen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
        }

        private void button_hochladen_Click(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Show();
        }

      

        private void comboBox_Marke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(comboBox_Marke.SelectedValue.Equals("BMW"))
            {
                comboBox_Modell.Items.RemoveAt(0);
            }
        }
    }
}
