using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffdprDataAdapterDataSet
{
    public partial class Form1 : Form
    {
        OleDbConnection conn;
        DataTable dt;
        OleDbDataAdapter da;
        DataSet ds;
        OleDbCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbIV_convertito_originale.mdb");
            ds = new DataSet("vendite");
            lstTabelle.Items.Clear();
            conn.Open();
            dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow riga in dt.Rows)
            {
                lstTabelle.Items.Add(riga["TABLE_NAME"].ToString());
            }
            string query;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                query = "SELECT * FROM " + dt.Rows[i]["TABLE_NAME"].ToString();
                da = new OleDbDataAdapter(query, conn);
                da.Fill(ds, dt.Rows[i]["TABLE_NAME"].ToString());
            }
            conn.Close();
        }

        
        private void btnTabelle_Click(object sender, EventArgs e)
        {
            string query;
            conn.Open();
            query = "SELECT * FROM Agenti";
            da = new OleDbDataAdapter(query, conn);
            da.Fill(ds, "Agenti");

            query = "SELECT * FROM Clientla";
            da = new OleDbDataAdapter(query, conn);
            da.Fill(ds, "Clientla");

            query = "SELECT * FROM Vendite";
            da = new OleDbDataAdapter(query, conn);
            da.Fill(ds, "Vendite");

            conn.Close();

            foreach (DataTable tabella in ds.Tables)
            {
                lstTabelle.Items.Add(tabella.TableName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstTabelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTabelle.SelectedIndex != -1)
            {
                dgvDatiTabella.DataSource = ds;
                dgvDatiTabella.DataMember = ds.Tables[lstTabelle.SelectedIndex].TableName;
            }
        }

        private void dgvDatiTabella_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM " + lstTabelle.Items[lstTabelle.SelectedIndex].ToString();
            da = new OleDbDataAdapter(query, conn);
            cb = new OleDbCommandBuilder(da);
            da.Update(ds.Tables[lstTabelle.SelectedIndex]);
            dgvDatiTabella.DataMember = null;
            dgvDatiTabella.DataMember = ds.Tables[lstTabelle.SelectedIndex].ToString();
        }

        private void lstStato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            lstStato.Items.Clear();
            if (lstTabelle.SelectedIndex != -1)
            {
                DataTable tabella = ds.Tables[lstTabelle.SelectedIndex];
                foreach (DataRow riga in tabella.Rows)
                {
                    lstStato.Items.Add(riga.RowState.ToString());
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (lstTabelle.SelectedIndex != -1)
            {
                DataTable tabella = ds.Tables[lstTabelle.SelectedIndex];
                tabella.RejectChanges();
                dgvDatiTabella.DataSource = tabella;
            }
        }

        private void btnTabDb_Click(object sender, EventArgs e)
        {
            lstTabelle.Items.Clear();
            conn.Open();
            dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE"});
            foreach (DataRow riga in dt.Rows)
            {
                lstTabelle.Items.Add(riga["TABLE_NAME"].ToString());
            }
            dgvDatiTabella.DataSource = dt;
            conn.Close();
        }

    }
}
