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
namespace FileBinario
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    struct studente
    {
        
        public string c_nome;//20 BYTE +1
        public string nome;//20 BYTE +1
        public int informatica;//4 BYTE
        public int sistemi;//4 BYTE
    }
    public partial class MainWindow : Window
    {
        const int lrec = 50;
        const int lstring = 20;
        FileStream fs;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void apri_Click(object sender, RoutedEventArgs e)
        {
            
                fs = new FileStream("classe,dat", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
           
        }

        private void Modifica_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private bool Lettura( int posizione,out studente st)
        {
            st = new studente();

            BinaryReader br = new BinaryReader(fs,Encoding.UTF8, true);
            int posRecord = lrec * (posizione - 1);

            if (posRecord >= fs.Length)
                return false;
            br.BaseStream.Seek(posRecord, SeekOrigin.Begin);
           if (br.PeekChar() ==0)//verifica posizione record vuoto
               return false;
            st.nome = br.ReadString();
            posRecord += lstring + 1;
            br.BaseStream.Seek(posRecord, SeekOrigin.Begin);
            st.c_nome = br.ReadString();
            posRecord += lstring + 1;
            br.BaseStream.Seek(posRecord, SeekOrigin.Begin);
            st.informatica = br.ReadInt32();
            st.sistemi = br.ReadInt32();
            br.Close();
            return true;
        }

        private void leggi_Click(object sender, RoutedEventArgs e)
        {
            studente st;
            int posizione=0;
            if (txtPosizione.Text != "")
            {
                posizione = Convert.ToInt32(txtPosizione.Text);

                if (posizione > 0)
                {
                    if (Lettura(posizione,out st))
                    {
                        txtNome.Text = st.nome;
                        txtCnome.Text = st.c_nome;
                        txtInfo.Text = st.informatica.ToString();
                        txtSis.Text = st.sistemi.ToString();
                    }
                    else
                        MessageBox.Show("Elemento inesistente", "Errore",MessageBoxButton.OK,MessageBoxImage.Error);

                }
                else
                    MessageBox.Show("Posizione Errata", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void scrivi_Click(object sender, RoutedEventArgs e)
        {
            studente st;
            int posizione;

            if (ctrlInput(out posizione,out st))
                Scrivi(posizione,st);
            else
                MessageBox.Show("Inserimento dati errato", "Errore",MessageBoxButton.OK,MessageBoxImage.Error);
        }
        private bool ctrlInput(out int posizione,out studente st)
        {
            posizione = 0;
            st = new studente();
            if (txtPosizione.Text != "" && txtNome.Text != "" && txtCnome.Text != "" && txtInfo.Text != "" && txtSis.Text != "")
            {
                st.c_nome = txtNome.Text;
                st.nome = txtCnome.Text;
                try
                {
                    posizione = Convert.ToInt32(txtPosizione.Text);
                    st.informatica = Convert.ToInt32(txtInfo.Text);
                    st.sistemi = Convert.ToInt32(txtSis.Text);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
                return false;
        }
        private void Scrivi(int posizione,studente st)
        {
            int posRecord = lrec * (posizione - 1);
            BinaryWriter bw = new BinaryWriter(fs,Encoding.UTF8, true); 
            bw.BaseStream.Seek(posRecord, SeekOrigin.Begin);
            bw.Write(st.nome.Length > lstring ? st.nome.Substring(0, lstring) : st.nome);
            posRecord += lstring + 1;
            bw.BaseStream.Seek(posRecord, SeekOrigin.Begin);
            bw.Write(st.c_nome.Length > lstring ? st.c_nome.Substring(0, lstring) : st.c_nome);
            posRecord += lstring + 1;
            bw.BaseStream.Seek(posRecord, SeekOrigin.Begin);        
            bw.Write(st.informatica);
            bw.Write(st.sistemi);
            bw.Close();
        }

        private void salva_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
