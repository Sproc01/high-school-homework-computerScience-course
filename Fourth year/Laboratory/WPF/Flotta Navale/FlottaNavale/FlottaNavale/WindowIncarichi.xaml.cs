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

namespace FlottaNavale
{
    /// <summary>
    /// Logica di interazione per WindowIncarichi.xaml
    /// </summary>
    public partial class WindowIncarichi : Window
    {
        List<Comandante> comandanti;
        List<Nave> navi;
        Incarico _incarico;
        List<Posizione> posizioni;
        public Incarico Incarico//proprietà per ritornare l'oggetto al form principale
        {  get { return _incarico; } }
        public WindowIncarichi(List<Comandante> c, List<Nave> n)
        {
            InitializeComponent();
            //assegnazioni liste per listbox
            comandanti = c;
            navi = n;
            listboxcom.ItemsSource = comandanti;
            listboxnavi.ItemsSource = navi;
            dtinizio.SelectedDate = DateTime.Now;//valore default
            btnok.Visibility = Visibility.Hidden;
        }

        private void btnannulla_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnok_Click(object sender, RoutedEventArgs e)
        {
            int i = listboxcom.SelectedIndex;
            int j = listboxnavi.SelectedIndex;
            if (i != -1 && j != -1)//controllo comandante e nave selezionati
            {
                _incarico = new Incarico((DateTime)dtinizio.SelectedDate, navi[j], comandanti[i],new List<Posizione> ());//creazione incarico
                DialogResult = true;
            }
            else
                MessageBox.Show("Selezionare nave e comandante", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void Button_Click(object sender, RoutedEventArgs e)//rotta open
        {
            WindowRotta window = new WindowRotta();
            window.ShowDialog();
            if ((bool)window.DialogResult)
            {
                posizioni = window.lista;
                btnok.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Errore", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
