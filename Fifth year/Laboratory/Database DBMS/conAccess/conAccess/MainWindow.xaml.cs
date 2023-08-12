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

namespace conAccess
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection con;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string perc = Environment.CurrentDirectory;
            con = new OleDbConnection();
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source ="+perc+"\\Auto.accdb";
            try
            {
                con.Open();
                MessageBox.Show("Connessione eseguita " + con.ServerVersion + "\r\n" + con.ConnectionString);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Connessione fallita" + ex.ToString());
            }
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //        con.Close();
            //}
        }

        private void btninserisci_Click(object sender, RoutedEventArgs e)
        {
            OleDbCommand cmd;
            string sql = string.Format("INSERT INTO MARCHE (MARCA,CITTA) VALUES (@MARCA , @CITTA)");
            cmd = new OleDbCommand(sql, con);
            OleDbParameter param = new OleDbParameter("@MARCA", OleDbType.VarChar, 20);
            cmd.Parameters.Add(param);
            param = new OleDbParameter("@CITTA", OleDbType.VarChar, 20);
            cmd.Parameters.Add(param);
            cmd.Parameters[0].Value = "Toyota";
            cmd.Parameters[1].Value = "c";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserimento corretto");
                con.Close();
            }
            catch (OleDbException ex)
            {
               MessageBox.Show( ex.Message);
            }
        }
    }
}
