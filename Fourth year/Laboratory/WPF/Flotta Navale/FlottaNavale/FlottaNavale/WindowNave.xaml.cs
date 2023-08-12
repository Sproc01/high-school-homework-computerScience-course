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
    /// Logica di interazione per WindowNave.xaml
    /// </summary>
    public partial class WindowNave : Window
    {
        Nave n;
        public Nave Nave//proprietà per ritornare l'oggetto al form principale
        {  get { return n; } }
        public WindowNave()
        {//inserimento
            InitializeComponent();
            rdbmodifica.Visibility = Visibility.Hidden;
            btncancella.Visibility = Visibility.Hidden;
        }
        public WindowNave(Nave nave)
        {//modifica e cancella
            InitializeComponent();
            btnok.Visibility = Visibility.Hidden;
            n = nave;
            txtnome.Text = n.Nome;
            txtnome.IsReadOnly = true;
            txtstazza.Text = n.Stazza.ToString();
            txtvelocità.Text = n.Velocità.ToString();
            switch (n.Stato)
            {//determino modifiche possibili
                case statonav.cantiere:
                    cmbstato.SelectedIndex = 0;
                    break;
                case statonav.varata:
                    cmbstato.SelectedIndex = 1;
                    txtvelocità.IsReadOnly = true;
                    txtstazza.IsReadOnly = true;
                    break;
                case statonav.demolita:
                    cmbstato.SelectedIndex = 2;
                    txtvelocità.IsReadOnly = true;
                    txtstazza.IsReadOnly = true;
                    cmbstato.IsEnabled = false;
                    rdbmodifica.Visibility = Visibility.Hidden;
                    break;
            }
        }
        private void btnok_Click(object sender, RoutedEventArgs e)//bottone ok
        {
            statonav stato=statonav.cantiere;
            if (txtnome.Text != "" && txtstazza.Text != "" && txtvelocità.Text != "")//controllo input corretto
            {
                double v = double.Parse(txtvelocità.Text);
                double s = double.Parse(txtstazza.Text);
                switch (cmbstato.Text)
                {
                    case "Varata":
                        stato = statonav.varata;
                        break;
                    case "Cantiere":
                        stato = statonav.cantiere;
                        break;
                    case "Demolita":
                        stato = statonav.demolita;
                        break;
                }
                
                DialogResult = true;
                n = new Nave(txtnome.Text, s, v, stato);//creazione nave
            }
            else
                MessageBox.Show("Errore dati input", "Errore", MessageBoxButton.OK,MessageBoxImage.Error);

        }

        private void btnannulla_Click(object sender, RoutedEventArgs e)//bottone anulla
        {
            DialogResult = false;
        }

        private void txtstazza_PreviewTextInput(object sender, TextCompositionEventArgs e)//preview text input nel textstazza e txtvelocità
        {//controllo testo corretto
            char i = e.Text[0];
            bool trovata = false;
            if(sender==txtstazza)//distinzione textbox
            {
                for (int j = 0; j < txtstazza.Text.Length && !trovata; j++)
                {
                    if (txtstazza.Text[j] == ',')//ricerca se già presente la virgola
                        trovata = true;
                }
            }
            else
            {
                for (int j = 0; j < txtvelocità.Text.Length && !trovata; j++)
                {
                    if (txtvelocità.Text[j] == ',')//ricerca se già presente la virgola
                        trovata = true;
                }
            }
            if (!trovata)
                e.Handled = !char.IsDigit(i) && i != ',';
            else
                e.Handled = !char.IsDigit(i);
        }

        private void btncancella_Click(object sender, RoutedEventArgs e)//bottone cancella
        {
            n = null;
            DialogResult = true;
        }

        private void rdbmodifica_Checked(object sender, RoutedEventArgs e)//checked modifica
        {
            btncancella.Visibility = Visibility.Hidden;
            btnok.Visibility = Visibility.Visible;
        }

        private void rdbmodifica_Unchecked(object sender, RoutedEventArgs e)//unchecked modifica
        {
            btncancella.Visibility = Visibility.Visible;
            btnok.Visibility = Visibility.Hidden;
        }
    }
}
