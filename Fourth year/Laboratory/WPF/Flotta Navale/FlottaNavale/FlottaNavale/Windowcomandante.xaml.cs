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
using libraryflotta;

namespace flottanavale
{
    /// <summary>
    /// Logica di interazione per Windowcomandante.xaml
    /// </summary>
    public partial class Windowcomandante : Window
    {
        Comandante c;
        public Windowcomandante()
        {//inserimento
            InitializeComponent();
            btncancella.Visibility = Visibility.Hidden;
            rdbmodifica.Visibility = Visibility.Hidden;
            clndata.SelectedDate = DateTime.Now;
        }
        public Windowcomandante(Comandante com)
        {//modifica e cancella
            InitializeComponent();
            c = com;
            btnok.Visibility = Visibility.Hidden;
            txtnome.Text = c.Nome;
            txtnome.IsReadOnly = true;
            txttelefono.Text = c.Telefono;
            clndata.SelectedDate = c.Datanascita;
            clndata.IsEnabled = false;
            switch (c.Stato)
            {//determino modifiche possibili
                case statocap.servizio:
                    cmbtipo.SelectedIndex = 1;
                    break;
                case statocap.pensione:
                    cmbtipo.SelectedIndex = 0;
                    txttelefono.IsReadOnly = true;
                    rdbmodifica.Visibility = Visibility.Hidden;
                    cmbtipo.IsEnabled = false;
                    break;
                case statocap.licenziato:
                    cmbtipo.SelectedIndex = 2;
                    txttelefono.IsReadOnly = true;
                    rdbmodifica.Visibility = Visibility.Hidden;
                    cmbtipo.IsEnabled = false;
                    break;
            }
        }
        public Comandante Comandante//proprietà per ritornare l'oggetto al form principale
        {
            get { return c; }
        }
        private void btnannulla_Click(object sender, RoutedEventArgs e)//bottone annulla
        {
            DialogResult = false;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)//bottone ok
        {
            statocap stato= statocap.servizio;
            if (txtnome.Text != "" && txttelefono.Text != ""&& txttelefono.Text.Length==10)//controllo input
            {
                DialogResult = true;
                switch (cmbtipo.Text)
                {
                    case "Licenziato":
                        stato = statocap.licenziato;
                        break;
                    case "Pensione":
                        stato = statocap.pensione;
                        break;
                    case "Servizio":
                        stato = statocap.servizio;
                        break;
                }
                c= new Comandante(txtnome.Text, txttelefono.Text, (DateTime)clndata.SelectedDate, stato);//creazione comandante
            }
            else
                MessageBox.Show("Dati errati", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void txttelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)//preview text input nel numero
        {
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }

        private void rdbmodifica_Unchecked(object sender, RoutedEventArgs e)//checked modifica
        {
            btncancella.Visibility = Visibility.Visible;
            btnok.Visibility = Visibility.Hidden;
        }

        private void rdbmodifica_Checked(object sender, RoutedEventArgs e)//unchecked modifica
        {
            btncancella.Visibility = Visibility.Hidden;
            btnok.Visibility = Visibility.Visible;
        }

        private void btncancella_Click(object sender, RoutedEventArgs e)//bottone cancella
        {
            c = null;
            DialogResult = true;
        }
    }
}
