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
using library;

namespace conto.corrente
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// Michele Sprocatti
    /// Funzionamento:
    /// Inserisci cliente tramite form modale, no clienti con lo stesso nome
    /// il numero di conto è generato automaticamente dalla classe banca ABC123XYZ(numero progressivo(parte da 001))
    /// listbox costruita con databinding
    /// se si seleziona l'elemento nella listbox compare nome e numero di conto(se presente) in basso
    /// nuovo movimento apre form modale si basa su nome presente nella textbox
    /// mentre si visualizzano i movimenti di un conto se ne possono anche aggiungere
    /// iterazione tra form fatta tramite metodo pubblico nel form modale che ritorna il valore
    /// </summary>
    public partial class MainWindow : Window
    {
        Banca b = new Banca();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btninseriscicliente_Click(object sender, RoutedEventArgs e)
        {
            string n = txtnome.Text;
            Windowpersona dialog;
            if (b.ricerca(n)==-1)
                dialog = new Windowpersona(txtnome.Text);//form modale
            else
                dialog = new Windowpersona("");
            dialog.ShowDialog();
            if(dialog.DialogResult==true)
            {
                Persona p = dialog.returnper();//metodo che ritorna persona
                if (b.ricerca(p.Nome) == -1)//controllo se persona già presente
                {
                    b.Addcliente(p);
                    listbox.ItemsSource = null;
                    listbox.ItemsSource = b.listclienti;//databinding listbox
                    listbox.IsEnabled = true;
                }
                else
                    MessageBox.Show("Elemento già presente", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Asterisk);

            }
        }

        private void btncreamovimento_Click(object sender, RoutedEventArgs e)
        {
            int i =b.ricerca(txtnome.Text);//ricerca della persona tramite nome
            if (i != -1 && i<b.listconti.Count)
            {
                WindowMovimenti dialog = new WindowMovimenti();
                dialog.ShowDialog();
                if (dialog.DialogResult == true)
                {
                    Movimento m = dialog.returnM();
                    if (b.Getconto(i).Saldo >= m.Importo && m.Tipo == Tipo.prelievo || m.Tipo == Tipo.versamento)//controllo se si può prelevare
                        b.Getconto(i).addmovimento(m);//metodo nel form modale che ritorna un movimento
                    else
                    {
                        MessageBox.Show("Impossibile prelevare questa cifra", "Non ci sono abbastanza soldi", MessageBoxButton.OK, MessageBoxImage.Error);
                        btncreamovimento_Click(this, null);
                    }
                }
            }
            else
            {
                if(i == -1)
                {
                     MessageBox.Show("Elemento cercato non presente", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Nessun conto presente", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if(!listbox.IsEnabled)//controllo per aggiornare listbox dei movimenti
            {
                btnvisualizzamovimenti_Click(this, null);
            }
        }

        private void inserisciconto_Click(object sender, RoutedEventArgs e)
        {
            Conti c;
            int pos = b.ricerca(txtnome.Text);
            if (pos != -1)
            {
                if (b.listclienti.Count != b.listconti.Count)//controllo se conto già presente o no
                {
                    c = new Conti(b.GetPersona(pos));
                    lbconto.Content = c.Nconto;
                    b.Addconto(c);//aggiunta del conto
                }
                else
                    MessageBox.Show("Conto già associato","attenzione",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
                MessageBox.Show("Elemento cercato non presente","Attenzione",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void btnvisualizzamovimenti_Click(object sender, RoutedEventArgs e)
        {
            int i = b.ricerca(txtnome.Text);
            Conti c;
            if(i!=-1 && i < b.listconti.Count)
            {
                c = b.Getconto(i);
                listbox.IsEnabled = false;//disattivazione selezione listbox
                listbox.ItemsSource = null;
                listbox.ItemsSource=c.Listmov;//databinding listbox
                MessageBox.Show(c.Saldo.ToString()+"€", "Il suo saldo è");
            }
            else
            if(sender!=btncreamovimento)
               if (i == -1)
                MessageBox.Show("Elemento cercato non presente", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                MessageBox.Show("Nessun conto presente", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnvisualizzaclienti_Click(object sender, RoutedEventArgs e)
        {
            listbox.ItemsSource = null;
            listbox.ItemsSource = b.listclienti;//databinding listbox
            listbox.IsEnabled = true;
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {//cambio selezione per cambio textbox e label conto
            if (listbox.IsEnabled)
            {
                lbconto.Content = "";
                txtnome.Text = "";
                if (listbox.SelectedIndex != -1 && listbox.SelectedIndex < b.listconti.Count)
                    lbconto.Content = b.Getconto(listbox.SelectedIndex).Nconto;
                if (listbox.SelectedIndex != -1)
                    txtnome.Text = b.GetPersona(listbox.SelectedIndex).Nome;
            }
        }

        private void txtnome_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            listbox.SelectedIndex = -1;
        }
    }
}
