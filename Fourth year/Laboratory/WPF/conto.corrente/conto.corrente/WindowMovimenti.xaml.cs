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
using library;

namespace conto.corrente
{
    /// <summary>
    /// Logica di interazione per WindowMovimenti.xaml
    /// </summary>
    public partial class WindowMovimenti : Window
    {
         Movimento m;
        public WindowMovimenti()
        {
            InitializeComponent();
            calendar.SelectedDate = DateTime.Now;//data all'avvio corrisponde all'odierna
            txtimporto.Focus();
            cmbtipo.SelectedIndex = 1;
        }

        public Movimento returnM()//metodo che ritorna il movimento
        {
            return m;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {//controllo input dati
            if(txtimporto.Text!="")
            {
                double i = Convert.ToDouble(txtimporto.Text);
                m = new Movimento((DateTime)calendar.SelectedDate, i, cmbtipo.Text);
                DialogResult = true;
            }
            else
                MessageBox.Show("Dati errati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void txtimporto_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {//controllo carattteri validi
            char i=e.Text[0];
            bool trovata=false;
            for (int j = 0; j < txtimporto.Text.Length&& !trovata; j++)
            {
                if (txtimporto.Text[j] == ',')
                    trovata = true;
            }
            if (!trovata)
                e.Handled = !char.IsDigit(i) && i != ',';
            else
                e.Handled = !char.IsDigit(i);
        }

        private void btnannulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
