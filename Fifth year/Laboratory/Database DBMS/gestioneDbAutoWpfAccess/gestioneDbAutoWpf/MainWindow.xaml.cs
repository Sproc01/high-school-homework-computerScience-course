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
using System.Data.OleDb;
using System.Data;

namespace gestioneDbAutoWpf
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection conn;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            if (conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    textBox1.Text += "Connessione chiusa" + Environment.NewLine;
                    conn = null;
                }
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            string perc = Environment.CurrentDirectory;
            textBox1.Clear();
            if (conn == null)
                try
                {
                    conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=" + perc+"\\Auto.accdb");
                    textBox1.Text += "Connessione creata" + Environment.NewLine;
                }
                catch (OleDbException ex)
                {
                    textBox1.Text += "Errore di connessione" + ex.ToString() + Environment.NewLine;
                }
            else
                textBox1.Text += "Connessione già avvenuta" + Environment.NewLine;

            if (conn.State != ConnectionState.Open)
                try
                {
                    conn.Open();
                    textBox1.Text += "Connessione aperta" + Environment.NewLine;
                }
                catch (OleDbException ex)
                {
                    textBox1.Text += "Errore nell'apertura connessione" + ex.ToString() + Environment.NewLine;
                }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            if (conn != null)
            {
                textBox1.Text += "Data Source: " + conn.DataSource + Environment.NewLine;
                textBox1.Text += "Connection String: " + conn.ConnectionString + Environment.NewLine;
                textBox1.Text += "Connection state: " + conn.State + Environment.NewLine;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                Insert win = new Insert(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (conn != null)
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    textBox1.Text += "Connessione chiusa" + Environment.NewLine;
                    conn = null;
                }
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                Delete win = new Delete(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            if (conn != null && conn.State == ConnectionState.Open)
            {
                showGrid win = new showGrid(conn);
                win.Show();
            }
            else
                textBox1.Text = "Connessione non aperta";
        }
    }
}
