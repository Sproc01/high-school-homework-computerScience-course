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

namespace PrepVerifica
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void connessioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string env = Environment.CurrentDirectory;
            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + env + "\\Db.accdb");
            try
            {
                con.Open();
                MessageBox.Show("Correct connection", "Connection");
            }
            catch (OleDbException i)
            {
                MessageBox.Show(i.ToString(),"Error");
            }
            Visualizza();
        }
        private void Visualizza()
        {
            dataGridView1.Rows.Clear();
            if (con != null)
            {
                string query = "SELECT * FROM STUDENTI";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader dr = cmd.ExecuteReader();
                DataTable d1 = new DataTable();
                d1.Load(dr);
                dataGridView1.DataSource = d1;
                dr.Close();
            }
        }
        private void inserireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                Insert win = new Insert(con, true);
                win.ShowDialog();
                Visualizza();
            }
            else
                MessageBox.Show("Connection not open", "Connection");
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                Insert win = new Insert(con, false);
                win.ShowDialog();
                Visualizza();
            }
            else
                MessageBox.Show("Connection not open", "Connection");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con != null)
                con.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult risposta = MessageBox.Show("Remove row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (risposta == DialogResult.Yes)
            {
                int selRow = dataGridView1.CurrentRow.Index;
                string Nome = dataGridView1[1, selRow].Value.ToString();
                string sql = string.Format("DELETE FROM STUDENTI WHERE NOME = '{0}'", Nome);
                OleDbCommand cmd = new OleDbCommand(sql, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Correct Delete", "Delete");
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Delete");
                }
                Visualizza();
            }
        }
    }
}
