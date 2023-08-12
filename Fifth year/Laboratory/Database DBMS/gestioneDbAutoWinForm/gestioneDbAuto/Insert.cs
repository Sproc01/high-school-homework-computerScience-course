using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestioneDbAuto
{
    public partial class Insert : Form
    {
        SqlConnection conn;
        public Insert(SqlConnection c)
        {
            InitializeComponent();
            conn = c;
        }
        private int inse(string marca, string citta, out string message)
        {
            SqlCommand cmd;
            string sql = string.Format("INSERT INTO MARCHE (MARCA, CITTA) values('{0}','{1}') ", marca,citta);
            cmd = new SqlCommand(sql, conn);
            try
            {
                message = "inserimento corretto";
                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return -1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string messagge;
            if (inse(txtMarca.Text, txtCitta.Text, out messagge) != -1)
                MessageBox.Show(messagge, "Inserimento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(messagge, "Inserimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
