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
using System.IO;

namespace fileHash
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// Michele Sprocatti 5E
    /// Garantite tutte le funzionalità del file hash
    /// Il programma effettua tutti i controlli su input necessari
    /// File si crea o si apre nel window loaded
    /// </summary>
    public partial class MainWindow : Window
    {
        HashFile hash;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {//apro o creo file nel loaded
            hash = new HashFile("f1.hash", 10, 0.2);
            Visualizza();
        }

        private void VisualPersona(Persona p, int i, bool occupato, ref int liberi, ref int occupati)
        {//metodo per scrivere textblock con persone
            TextBlock txt = new TextBlock();
            txt.TextWrapping = TextWrapping.Wrap;
            txt.FontFamily = new FontFamily("Courier New");
            if (occupato)
            {
                occupati++;
                txt.Text = $"N°{ i,-2}){p.ToString()}";
            }
            else
            {
                liberi++;
                txt.Text = string.Format("N°{0,-2})Libero", i);
            }
            st1.Children.Add(txt);
        }

        private void Visualizza()
        {//aggiorna stackpanel con la visualizzazione degli elementi
            int liberi=0;
            int occupati=0;
            st1.Children.Clear();
            TextBlock txt;
            for (int i = 0; i < hash.Dimfile; i++)
            {
                bool occupato = hash.ReadPersona(i, out Persona p);
                if (i >= 0 && i < (hash.Dimfile - hash.DimensioneOverflow))
                {//zona primaria
                    if (i == 0)
                    {//solo prima volta
                        txt = new TextBlock();
                        txt.Text = "Zona Primaria:";
                        txt.Foreground = Brushes.Green;
                        txt.TextWrapping = TextWrapping.Wrap;
                        txt.FontFamily = new FontFamily("Courier New");
                        st1.Children.Add(txt);
                    }
                    VisualPersona(p, i, occupato, ref liberi, ref occupati);
                }
                else
                {//zona overflow
                    if (i == (hash.Dimfile - hash.DimensioneOverflow))
                    {//solo prima del primo elemento overflow
                        txt = new TextBlock();
                        txt.Text = "Zona Overflow:";
                        txt.Foreground = Brushes.Green;
                        txt.TextWrapping = TextWrapping.Wrap;
                        txt.FontFamily = new FontFamily("Courier New");
                        st1.Children.Add(txt);
                    } 
                    VisualPersona(p, i,occupato,ref liberi, ref occupati);
                }
                if (i == hash.Dimfile - 1)
                {//alla fine della visualizza textbloc con numero occupati e numero liberi
                    txt = new TextBlock();
                    txt.Text = $"\nLiberi: {liberi}, occupati: {occupati}\n";
                    txt.FontFamily = new FontFamily("Courier New");
                    st1.Children.Add(txt);
                }
            }
        }

        private void btnaggiugni_Click(object sender, RoutedEventArgs e)
        {
            Persona p = new Persona();
            if (txtnome.Text != "" && txtcognome.Text != "" && txtCredito.Text != "" && txtTelefono.Text != "" && txtTelefono.Text.Length == 10)//dati consistenti
            {
                p.nome = txtnome.Text;
                p.cognome = txtcognome.Text;
                p.credito = Convert.ToDouble(txtCredito.Text);
                p.nTelefono = txtTelefono.Text;
                try
                {//se elemento già presente lancio eccezione
                    hash.Aggiungi(p);
                    Visualizza();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
            else
                MessageBox.Show("Errore dati di input");
        }

        private void txtCredito_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //scrivere solo numeri e soltanto una virgola utilizzando il punto(.)
            char i = e.Text[0];
            if (txtCredito.Text.IndexOf('.') == -1 && txtCredito.Text.Length>0)
                e.Handled = !char.IsDigit(i) && i != '.';
            else
                e.Handled = !char.IsDigit(i);
        }

        private void btncancella_Click(object sender, RoutedEventArgs e)
        {
            if (txtnome.Text != "" && txtcognome.Text != "")//dati consistenti
            {                   
                try
                {
                    //se elemento non presente lancio eccezione
                    hash.Cancella(txtnome.Text,txtcognome.Text);
                    Visualizza();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
            else
                MessageBox.Show("Errore dati di input");
        }

        private void btnmodifca_Click(object sender, RoutedEventArgs e)
        {
            Persona p = new Persona();
            if (txtnome.Text != "" && txtcognome.Text != "" && txtCredito.Text != "")//dati consistenti
            {
                p.nome = txtnome.Text;
                p.cognome = txtcognome.Text;
                p.credito = Convert.ToDouble(txtCredito.Text);
                p.nTelefono = txtTelefono.Text;
                try
                {
                    //se elemento non presente lancio eccezione
                    hash.Modifica(p);
                    Visualizza();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
            else
                MessageBox.Show("Errore dati di input");
        }

        private void txtnome_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //solo lettere su nome
            char i = e.Text[0];
            e.Handled = !char.IsLetter(i);
        }

        private void btnpulisci_Click(object sender, RoutedEventArgs e)
        {//inizializzo file
            hash.Pulisci();
            Visualizza();
        }

        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //scrivere solo numeri
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }
    }
}
