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
using System.Windows.Shapes;

namespace FlottaNavale
{
    /// <summary>
    /// Logica di interazione per Windowopen.xaml
    /// </summary>
    public partial class Windowopen : Window
    {
        string s;
        public Windowopen()
        {
            InitializeComponent();
        }
        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            s = txtnome.Text;
            MainWindow main = new MainWindow(s);
            main.Show();
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtnome.Visibility = Visibility.Visible;
            lbnome.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            lbnome.Visibility = Visibility.Hidden;
            txtnome.Visibility = Visibility.Hidden;
        }
    }
}
