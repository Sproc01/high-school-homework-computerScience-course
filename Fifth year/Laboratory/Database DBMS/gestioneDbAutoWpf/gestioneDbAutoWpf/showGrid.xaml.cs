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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace gestioneDbAutoWpf
{
    /// <summary>
    /// Logica di interazione per showGrid.xaml
    /// </summary>
    public partial class showGrid : Window
    {
        SqlConnection conn;
        public showGrid(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }
        private void visualizza(string sqlcmd)
        {
            SqlCommand cmd;
            SqlDataReader read;
            cmd = new SqlCommand(sqlcmd, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                listBox1.Items.Add(read.GetInt32(0) + " " + read.GetString(1) + " " + read.GetString(2));
            }
            read.Close();
        }
        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            visualizza("SELECT * FROM MARCHE");
        }
    }
}
