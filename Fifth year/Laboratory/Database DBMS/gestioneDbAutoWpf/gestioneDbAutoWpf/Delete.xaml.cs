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
    /// Logica di interazione per Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        SqlConnection conn;
        List<string> list = new List<string>();
        public Delete(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            visualizza("SELECT * FROM MARCHE");
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
                list.Add(read.GetInt32(0) + " " + read.GetString(1) + " " + read.GetString(2));
            }
            read.Close();
        }
        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private int Del(string marca, string città, out string message)
        {
            string sql = string.Format("DELETE MARCHE WHERE MARCA='{0}' AND  CITTA='{1}'", marca, città);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                message = "correct delete";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return -1;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult dr;
            dr = MessageBox.Show("Remove row?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (dr == MessageBoxResult.Yes)
            {
                int index = listBox1.SelectedIndex;
                string messagge;
                string[] arr = list[index].Split(' ');
                if (Del(arr[1],arr[2],out messagge)!=-1)
                    MessageBox.Show(messagge, "Delete", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                else
                    MessageBox.Show(messagge, "Delete", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }
    }
}
