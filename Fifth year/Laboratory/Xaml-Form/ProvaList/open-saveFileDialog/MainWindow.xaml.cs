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
using Microsoft.Win32;
using System.IO;

namespace open_saveFileDialog
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] vett;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Apri_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt;*.cs) |*.txt;*.cs|All files(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = true;
            openFile.CheckFileExists = true;
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFile.ShowDialog() == true)
            {
                vett = openFile.FileNames;
                listfile.ItemsSource = openFile.SafeFileNames;
            }
        }

        private void Salva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt;*.cs) |*.txt;*.cs|All files(*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show("Salva il file selezionato");
            if (saveFile.ShowDialog() == true)
            {
                path.Text = saveFile.FileName;
                File.WriteAllText(saveFile.FileName, texteditor.Text);
            } 
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void listfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int i = listfile.SelectedIndex;

            if (MessageBox.Show("Salvare le modifiche?", "Attenzione", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                Salva_Click(null, null);
            else
            if (i != -1)
            {
                path.Text = vett[listfile.SelectedIndex];
                texteditor.Text = File.ReadAllText(path.Text);
            }
        }
    }
}
