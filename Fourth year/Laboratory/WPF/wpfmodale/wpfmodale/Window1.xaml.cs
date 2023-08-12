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

namespace wpfmodale
{
    /// <summary>
    /// Logica di interazione per Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string pippo = "1";
        MainWindow Main;
        public Window1(MainWindow m)
        {
            InitializeComponent();
            Main = m;
        }

        private void btnannulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            Main.Messagebox();
            DialogResult = true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("chiudere", "attenzione", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (m == MessageBoxResult.No)
                e.Cancel = true;
        }
    }
}
