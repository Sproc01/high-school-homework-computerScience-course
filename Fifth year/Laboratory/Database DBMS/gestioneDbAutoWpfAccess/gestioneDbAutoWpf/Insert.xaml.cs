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
using System.Data.OleDb;

namespace gestioneDbAutoWpf
{
    /// <summary>
    /// Logica di interazione per Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        OleDbConnection conn;
        public Insert(OleDbConnection c)
        {
            InitializeComponent();
            conn = c;
        }

        private void btnclose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string messagge;
            if (inse(txtBrand.Text, txtCity.Text, out messagge) != -1)
                MessageBox.Show(messagge, "Insert",MessageBoxButton.OK, MessageBoxImage.Exclamation);
            else
                MessageBox.Show(messagge, "Insert", MessageBoxButton.OK, MessageBoxImage.Error);
            Close();
        }
        private int inse(string marca, string citta, out string message)
        {
            OleDbCommand cmd;
            string sql = string.Format("INSERT INTO MARCHE (MARCA, CITTÀ) values('{0}','{1}') ", marca, citta);
            cmd = new OleDbCommand(sql, conn);
            try
            {
                message = "Correct insert";
                return cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                message = ex.Message;
                return -1;
            }
        }
    }
}
