using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Verifica
{
    public partial class SearchEl : Form
    {
        OleDbConnection con;
        public SearchEl(OleDbConnection c)
        {
            InitializeComponent();
            con = c;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM CLIENTI WHERE NOME='{0}' AND COGNOME='{1}'",txtNome.Text, txtCognome.Text);
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                dataGridView1.DataSource = dt;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
