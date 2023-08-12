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

namespace DBAuto
{
    public partial class Search : Form
    {
        SqlConnection conn;
        public Search(SqlConnection c)
        {
            conn = c;
            InitializeComponent();
        }
        enum cerca
        {
            citta, marca, mc
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string citta = txtCitta.Text;
            cerca c = cerca.mc;
            if (rdBMarca.Checked)
                c = cerca.marca;
            if (rdBC.Checked)
                c = cerca.citta;
            if (marca != "" && citta != "")
                if (Cerca(marca, citta, c))
                    MessageBox.Show("Elemento trovato", "Ricerca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modifica non trovato", "Ricerca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Errore input");
        }

        private void btnchiudi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Cerca(string marca, string città, cerca c)
        {
            bool trov = false;
            string sql;
            if (c == cerca.citta)
                sql = $"SELECT COUNT (*) FROM MARCHE WHERE CITTA='{città}'";
            else
                if (c == cerca.marca)
                    sql = $"SELECT COUNT (*) FROM MARCHE WHERE MARCA='{marca}'";
            else
                sql = $"SELECT COUNT (*) FROM MARCHE WHERE CITTA='{città}' and MARCA='{marca}'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int i=(int)cmd.ExecuteScalar();
            if (i !=0)
                trov = true;
            return trov;
        }
    }
}
