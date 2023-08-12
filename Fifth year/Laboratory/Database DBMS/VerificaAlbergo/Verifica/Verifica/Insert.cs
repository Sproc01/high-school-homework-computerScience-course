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
    public partial class Insert : Form
    {
        OleDbConnection con;
        int n;
        public Insert(OleDbConnection c,int num, bool search)
        {
            InitializeComponent();
            con = c;
            n = num;
            if(search)
            {
                btnInsert.Visible = false;
                txtCitta.Enabled = false;
                txtProv.Enabled = false;
                txtCod.Enabled = false;
            }
            else
            {
                btnInsert.Visible = true;
                btnsearch.Visible = false;
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = string.Format("INSERT INTO CLIENTI(CODICE,NOME,COGNOME,CITTA, PROVINCIA, TELEFONO) VALUES('{0}','{1}','{2}','{3}', '{4}','{5}')",txtCod.Text, txtNome.Text, txtCognome.Text,txtCitta.Text,txtProv.Text,txtTel.Text);
            if (n < 5)
            {
                OleDbCommand cmd = new OleDbCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Correct insert", "Insert");
                    Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString(), "Insert");
                }
            }
            else
                MessageBox.Show("Database is full");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT COUNT(*) FROM CLIENTI WHERE TELEFONO='{0}' AND NOME='{1}' AND COGNOME='{2}'", txtTel.Text, txtNome.Text, txtCognome.Text);
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                int i=(int)cmd.ExecuteScalar();
                if(i>=1)
                    MessageBox.Show("Elemento presente", "Search");
                else
                    MessageBox.Show("Elemento non presente", "Search");
                Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString(), "Insert");
            }
        }
    }
}
