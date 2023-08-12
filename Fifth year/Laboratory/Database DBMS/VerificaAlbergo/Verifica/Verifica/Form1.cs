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
    public partial class Form1 : Form
    {
        OleDbConnection con;
        int num;
        public Form1()
        {
            InitializeComponent();
        }
        private void Visualizza()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM CLIENTI";
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                OleDbDataReader dr=cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                dataGridView1.DataSource = dt;
                
            }
            catch (OleDbException)
            {
                MessageBox.Show("Error");
            }
        }
        private void LabelNum()
        {
            string query = "SELECT COUNT (*) FROM CLIENTI";
            OleDbCommand cmd = new OleDbCommand(query, con);
            num = (int)cmd.ExecuteScalar();
            lbNum.Text ="Clienti presenti:"+ num.ToString();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (con != null)
                con.Close();
        }

        private void apriConnessioneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string env = Environment.CurrentDirectory;
            if(con==null)
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + env + "\\Clienti.accdb");
                try
                {
                    con.Open();
                    LabelNum();
                    Visualizza();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString(), "error");
                }

            }
            
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                Insert win = new Insert(con,num,false);
                win.ShowDialog();
                Visualizza();
                LabelNum();
            }
            else
                MessageBox.Show("Connection closed");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Remove row", "remove", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(dr==DialogResult.Yes)
            {
                int selrow = dataGridView1.CurrentRow.Index;
                string query=string.Format("DELETE FROM CLIENTI WHERE CODICE='{0}'",dataGridView1[0, selrow].Value.ToString());
                OleDbCommand cmd = new OleDbCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Correct delete", "delete");
                    Visualizza();
                    LabelNum();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString(), "delete");
                }
            }
        }

        private void yesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                Insert win = new Insert(con, num,true);
                win.ShowDialog();
            }
            else
                MessageBox.Show("Connection closed");
        }

        private void elementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
            {
                SearchEl win = new SearchEl(con);
                win.ShowDialog();
            }
            else
                MessageBox.Show("Connection closed");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fare doppio click nell'header della riga da cancellare");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (con != null)
                con.Close();
            Close();
        }
    }
}
