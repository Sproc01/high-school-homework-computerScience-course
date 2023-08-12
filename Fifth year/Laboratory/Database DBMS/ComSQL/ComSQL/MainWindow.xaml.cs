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
//per sql
using System.Data.SqlClient;
using System.Data;

namespace ComSQL
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection();
            //con.ConnectionString = "Data Source = INFORMATICA220; Initial Catalog = Auto; Integrated Security = true; Persist Security Info = False";
            //con.ConnectionString = "Server= .\\; Initial Catalog = Auto; Integrated Security = true; Persist Security Info = False";
            //con.ConnectionString = "Data Source = (local); Initial Catalog = Auto; Integrated Security = true; Persist Security Info = False";
            con.ConnectionString = "Data Source = INFORMATICA220; Initial Catalog = Auto; User ID=SA ; Password=123; Persist Security Info = False";
            try
            {
                con.Open();
                MessageBox.Show("Connessione eseguita "+ con.ServerVersion + "\r\n" + con.ConnectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connessione fallita"+ ex.ToString());
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
