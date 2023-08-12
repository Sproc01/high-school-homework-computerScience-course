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
            listzip.Items.Clear();
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openfile.Multiselect = false;
            openfile.CheckFileExists = true;
            openfile.Filter = "All files(*.*)|*.*";
            if (openfile.ShowDialog()==true)
            {
                File = new UnsplitSplitFile(openfile.FileName);
                txbpercorso.Text = " " + File.Percorso;
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
                listzip.Items.Clear();
                if (txtnparti.Text != "")
                {
                    FileStream[] vett = File.SplitFile(Convert.ToInt32(txtnparti.Text));
                    for (int i = 0; i < vett.Length; i++)
                    {
                        listzip.Items.Add(System.IO.Path.GetFileName(vett[i].Name));
                    }
                }
                else
                    MessageBox.Show("Inserire le parti in cui dividere il file");
            }
            else
                MessageBox.Show("File non selezionato");
        }

        private void btnunsplit_Click(object sender, RoutedEventArgs e)
        {
            if (listzip.Items.Count!=0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                save.Filter = "All files(*.*)|*.*";
                if (save.ShowDialog() == true)
                {
                    File.UnSplitFile(save.FileName+File.Extension);
                }
            }
            else
                MessageBox.Show("Impossibile riunire il file se non è stato diviso");
        }

        private void txtnparti_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char i = e.Text[0];
            e.Handled = !char.IsDigit(i);
        }
    }
}
