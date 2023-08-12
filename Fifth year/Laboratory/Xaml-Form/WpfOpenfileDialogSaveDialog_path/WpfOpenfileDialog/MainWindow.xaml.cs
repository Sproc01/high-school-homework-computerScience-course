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
//using System.Windows.Shapes;
using Microsoft.Win32;//namespace che contiene la classe openfiledialog
using System.IO;
namespace WpfOpenfileDialog
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            string nomefile;           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt,*.cs)|*.txt;*.cs|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;//permette la selezione multipla dei files
            openFileDialog.CheckFileExists = true;//Verifica l'esistenza del file selezionato
            openFileDialog.InitialDirectory =Environment.CurrentDirectory;
                     

            // openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog.ShowDialog() == true)
            {
                //nomefile = openFileDialog.SafeFileName;
                
                
                string path = openFileDialog.FileName;                
                txtEditor.Text += string.Format($"Percorso:{path},\r\nNome:{Path.GetFileName(path)},\r\nEstensione:{Path.GetExtension(path)},\r\n" +
                    $"directory:{Path.GetDirectoryName(path)}\r\n,Nuova estensione{Path.ChangeExtension(path,"pdf")}\r\n,Percorso assoluto{Path.GetFullPath(path)},\r\n" +
                    $"root:{Path.GetPathRoot(path)}");
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
                

        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt,*.cs)|*.txt;*.cs|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            //saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);


        }
    }
}
