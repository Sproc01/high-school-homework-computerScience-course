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
using Microsoft.Win32;//namespace per file
using System.IO;//namespace per file

namespace open_saveFileDialog
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

        private void Apri_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt;*.cs) |*.txt;*.cs|All files(*.*)|*.*";
            openFile.FilterIndex = 1;//l'indice del filtro che fa vedere
            openFile.Multiselect = false;//false perchè si può selezionare un file alla volta
            openFile.CheckFileExists = true;//controlla che il file esista
            //openFile.InitialDirectory = Environment.CurrentDirectory;
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//la ricerca inizia dalla cartella desktop
            if(openFile.ShowDialog()==true)
            {
                path.Text = openFile.FileName;
                texteditor.Text = File.ReadAllText(openFile.FileName);
            }

            
        }

        private void Salva_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt;*.cs) |*.txt;*.cs|All files(*.*)|*.*";
            saveFile.FilterIndex = 1;//l'indice del filtro che fa vedere
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(saveFile.ShowDialog()==true)
            {
                path.Text=saveFile.FileName;
                File.WriteAllText(saveFile.FileName, texteditor.Text);
            }

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
