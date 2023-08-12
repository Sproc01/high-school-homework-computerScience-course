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
using UnsplitSplitFileclass;
using System.IO;
using Microsoft.Win32;

namespace fileZipUnzip
{
    /// <summary>
    /// Michele Sprocatti 5E
    /// Controlli input effettuati
    /// File divisibile in quante parti si desidera
    /// Per compattare il file ci sono due casi, i quali dipendono dagli elementi presenti nella listbox:
    /// Primo caso: possibilità di compattare il file già diviso selezionando i vari file da un openfiledialog
    /// Secondo caso: possibilità di compattare il file appena diviso
    /// </summary>
    public partial class MainWindow : Window
    {
        UnsplitSplitFile File;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnapri_Click(object sender, RoutedEventArgs e)
        {
            btnpulisci_Click(null, null);//pulizia dati già presenti
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openfile.Multiselect = false;
            openfile.CheckFileExists = true;
            openfile.Filter = "All files(*.*)|*.*";
            if (openfile.ShowDialog()==true)
            {
                txbpercorso.Text = " " + openfile.FileName;
                File = new UnsplitSplitFile(openfile.FileName);
            }
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnslipt_Click(object sender, RoutedEventArgs e)
        {
            if (txbpercorso.Text != "")
            {
                listzip.ItemsSource = null;
                if (txtnparti.Text != "")
                {
                    File.SplitFile(Convert.ToInt32(txtnparti.Text));
                    string[] nomi = new string[File.Percorsi.Length];//vettore da utilizzare per il binding della lista
                    for (int i = 0; i < File.Percorsi.Length; i++)
                    {
                        nomi[i] = System.IO.Path.GetFileName(File.Percorsi[i]);
                    }
                    listzip.ItemsSource = nomi;
                }
                else
                    MessageBox.Show("Inserire le parti in cui dividere il file","Attenzione", MessageBoxButton.OK,MessageBoxImage.Asterisk);
            }
            else
                MessageBox.Show("File non selezionato", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }

        private void btnunsplit_Click(object sender, RoutedEventArgs e)
        {
            if (listzip.Items.Count!=0)//possibilità di compattare file già splittati
            {
                //costrutto try catch se succede che l'applicazione rimane aperta ma uno o più file divisi sono stati cancellati
                try
                {
                    FileStream fscontrollo;//variabile usata solo per effettuare il controllo
                    for (int i = 0; i < File.Percorsi.Length; i++)
                    {
                        fscontrollo = new FileStream(File.Percorsi[i], FileMode.Open);
                    }
                    Save();
                }
                catch (Exception)
                {
                    MessageBox.Show("File inesistenti","Errore");
                    btnpulisci_Click(null, null);
                }
            }
            else
            {
                //possibilità di selezionare i file divisi da open file dialog se listbox vuota
                MessageBox.Show("Seleziona i file da compattare");
                OpenFileDialog open = new OpenFileDialog();
                open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                open.Multiselect = true;
                open.CheckFileExists = true;
                open.Filter = "All files(*.*)|*.*";
                if(open.ShowDialog()==true)
                {
                    txtnparti.Text = open.FileNames.Length.ToString();
                    listzip.ItemsSource = open.SafeFileNames;
                    File=new UnsplitSplitFile(open.FileNames);
                    Save();
                }
            }
        }
        private void Save()//metodo per salvare il file compattato
        {
            MessageBox.Show("Salvare il file compattato");
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //specifico l'estensione del file da salvare usando quella del primo file selezionato
            save.Filter = string.Format("(*{0})|*{0}", System.IO.Path.GetExtension(File.Percorsi[0]));
            if (save.ShowDialog() == true)
            {
                File.UnSplitFile(save.FileName);
                MessageBox.Show("File salvato");
            }
        }

        private void txtnparti_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //controllo input
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }

        private void btnpulisci_Click(object sender, RoutedEventArgs e)
        {
            //pulisco listbox e textbox
            listzip.ItemsSource = null;
            txtnparti.Text = "";
            txbpercorso.Text = "";
        }
    }
}
